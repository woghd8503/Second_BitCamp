using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _118_MultiThreadChattingPlusServer
{
    class Program
    {
        static object keyObj = new object();// 임계영역 동기화 객체
        // 최초 연결시 등록하는 저장소
        static List<Socket> socketList = new List<Socket>();
        // id를 수신하면 socketList에서 idMap과 socketMap으로 이동하여 저장
        static Dictionary<string, Socket> idMap = new Dictionary<string, Socket>();
        static Dictionary<Socket, string> socketMap = new Dictionary<Socket, string>();
        const int PORT = 9000;
        static void Main(string[] args)
        {
            Socket serverSocket =
                new Socket(AddressFamily.InterNetwork,
                           SocketType.Stream,
                           ProtocolType.Tcp);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);

            serverSocket.Bind(ipep);
            serverSocket.Listen(100); // 이통사와 연결            
            while (true)
            {
                Console.WriteLine("[서버] 접속 대기중...");
                Socket connSocket = serverSocket.Accept();

                // 임계영역 동기화
                Monitor.Enter(keyObj);
                // 리스트에 소켓객체를 등록
                socketList.Add(connSocket);
                Monitor.Exit(keyObj);

                Console.WriteLine("[서버] 클라이언트 접속 연결~");
                Thread thread =
                    new Thread(new ParameterizedThreadStart(threadRead));
                thread.Start(connSocket);
                Console.WriteLine("[서버] 클라이언트 스레드 담당~");
            }
        }

        static void threadRead(object sock)
        {
            Socket connSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(connSocket);
            StreamReader sr = new StreamReader(ns);// ReadLine()
            StreamWriter sw = new StreamWriter(ns);// WriteLine()

            try  // 정상 실행을 시도
            {
                bool isRun = true;
                while (isRun)
                {
                    String strMsg = sr.ReadLine();
                    Console.WriteLine("[서버] : 수신 : " + strMsg);

                    isRun = processPacket(strMsg, connSocket, sw, sr);

                    if (strMsg == null)
                        break;
                }
            }
            catch (Exception e) // 예외 발생이 여기로 점프
            {
                // 연결이 종료된 소켓을 리스트에서 제거
                removeRegisterSocket(connSocket);
                Console.WriteLine(e.Message);
            }
            finally // 정상,예외 모두 무조건 최종 실행되는 구문
            {                              
                Console.WriteLine("[서버] 클라이언트 접속 종료...");
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (connSocket != null) connSocket.Close();
            }
        }

        static void removeRegisterSocket(Socket connSocket)
        {
            Monitor.Enter(keyObj);
            try
            {
                socketList.Remove(connSocket);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                string id = socketMap[connSocket];
                idMap.Remove(id);                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                socketMap.Remove(connSocket);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Monitor.Exit(keyObj);
        }
        
        static bool processPacket(String strPacket, Socket connSocket,
                                StreamWriter sw, StreamReader sr)
        {
            bool isRun = true;
            String[] dataArr = 
                strPacket.Split(new char[]{'|'});
            string id = "";
            string cmd = dataArr[0];
            string subCmd = "";
            switch (cmd)
            {
                case "I":
                    id = dataArr[1];
                    Console.WriteLine("[서버] 클라이언트 id 수신 : " + id);
                    moveListToMap(connSocket, id);
                    break;
                case "C":
                    subCmd = dataArr[1];
                    if (subCmd == "E")
                    {
                        bool isEnable = isChatting(connSocket);
                        if (isEnable)
                            sw.WriteLine("C|O");
                        else
                            sw.WriteLine("C|F");
                        sw.Flush();
                    }else if (subCmd == "M")
                    {
                        bool isEnable = isChatting(connSocket);
                        if (isEnable)
                        {
                            string msg = dataArr[2];
                            sendAllMsg(msg, connSocket);
                        }
                        else
                        {
                            sw.WriteLine("C|F");
                            sw.Flush();
                        }                        
                    }
                    break;
                case "W":
                    subCmd = dataArr[1];
                    if (subCmd == "E")
                    {
                        bool isEnable = isChatting(connSocket);
                        if (isEnable)
                            sw.WriteLine("W|O");
                        else
                            sw.WriteLine("W|F");
                        sw.Flush();
                    }else if(subCmd == "L")
                    {
                        sendWhisperIdList(sw, connSocket);
                    }
                    else if (subCmd == "M")
                    {
                        bool isEnable = isChatting(connSocket);
                        if (isEnable)
                        {
                            string receiveId = dataArr[2];
                            string msg = dataArr[3];
                            sendWhisper(msg, connSocket, receiveId);
                        }
                        else
                        {
                            sw.WriteLine("W|F");
                            sw.Flush();
                        }
                    }
                    break;
                case "A":
                    string op = dataArr[1];
                    double num0 = Double.Parse(dataArr[2]);
                    double num1 = Double.Parse(dataArr[3]);
                    double result = 0;
                    switch (op)
                    {
                        case "+":
                            result = num0 + num1;
                            break;
                        case "-":
                            result = num0 - num1;
                            break;
                        case "*":
                            result = num0 * num1;
                            break;
                        case "/":
                            result = num0 / num1;
                            break;
                        case "%":
                            result = num0 % num1;
                            break;
                    }
                    sw.WriteLine(String.Format("A|{0,2}", result));
                    sw.Flush();
                    break;
                case "E":
                    removeRegisterSocket(connSocket);
                    Console.WriteLine("[서버] 클라이언트 종료 요청");
                    isRun = false;
                    break;
            }

            return isRun;
        }

        static void moveListToMap(Socket connSocket, string id)
        {
            Monitor.Enter(keyObj);
            socketList.Remove(connSocket);
            idMap.Add(id, connSocket);
            socketMap.Add(connSocket, id);
            Monitor.Exit(keyObj);
        }

        static bool isChatting(Socket connSocket)
        {
            bool isEnable = true;
            Monitor.Enter(keyObj);
            foreach (Socket socket in socketList)
            {
                if (socket == connSocket)
                {
                    isEnable = false;
                    break;
                }
            }
            Monitor.Exit(keyObj);

            return isEnable;
        }

        static void sendWhisperIdList(StreamWriter sw, Socket exceptionSocket)
        {
            Monitor.Enter(keyObj);

            string packet = "W|L|";
            foreach (var data in idMap)
            {
                string id = data.Key;
                Socket socket = data.Value;                
                if (socket != exceptionSocket)
                {
                    packet += id + "|";
                }   
            }

            sw.WriteLine(packet);
            sw.Flush();

            Monitor.Exit(keyObj);
        }

        static void sendWhisper(string strMsg, Socket sendSocket, string receiveId)
        {
            Monitor.Enter(keyObj);
            
            string sendId = socketMap[sendSocket];

            Socket receiveSocket = idMap[receiveId];

            NetworkStream ns = new NetworkStream(receiveSocket);
            StreamWriter sw = new StreamWriter(ns);

            sw.WriteLine(String.Format("W|M|[{0} whisper] {1}", sendId, strMsg));
            sw.Flush();

            Monitor.Exit(keyObj);
        }

        static void sendAllMsg(String strMsg, Socket exceptionSocket)
        {
            Monitor.Enter(keyObj);

            string sendId = socketMap[exceptionSocket];

            foreach(var data in idMap)
            {
                string id = data.Key;
                Socket socket = data.Value;
                if(id != sendId)
                {
                    NetworkStream ns = new NetworkStream(socket);
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(String.Format("C|M|[{0}] {1}", sendId, strMsg));
                    sw.Flush();
                }
            }

            Monitor.Exit(keyObj);
        }
    }
}
