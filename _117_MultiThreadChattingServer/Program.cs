using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _117_MultiThreadChattingServer
{
    class Program
    {
        static object keyObj = new object(); // 임계영역 동기화
        static List<Socket> socketList = new List<Socket>();
        const int PORT = 9000;
        static void Main(string[] args)
        {
            // IPv4, 연결지향형, 신뢰성(정확성)
            // Accept 역할 담당 소켓
            // 휴대폰
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 주소(현재 Host IP, PORT에 정의된 숫자)
            // 휴대폰에 부여할 전화번호
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);

            // 소켓에 주소를  부여(휴대폰 개통)
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
                Console.WriteLine("[서버] 클라이언트  접속 연결~");
                Thread thread = new Thread(new ParameterizedThreadStart(threadRead));
                thread.Start(connSocket);
                Console.WriteLine("[서버] 클라이언트 스레드 담당");
            }
        }
        static void threadRead(object sock)
        {
            Socket connSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(connSocket);
            StreamReader sr = new StreamReader(ns);
            try // 정상 실행을 시도
            {
                while (true)
                {
                    string strMsg = sr.ReadLine();
                    Console.WriteLine("[서버] : 수신 : " + strMsg);
                    if (strMsg == null || strMsg == "exit")
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally // 정상, 예외 모두 모조건 최종 실행 되는 구문
            {
                Monitor.Enter(keyObj);
                // 연결이 종료된 소켓을 리스트에서 제거
                socketList.Remove(connSocket);
                Console.WriteLine("[서버] 클라이언트 접속 종료");
                if (sr != null) sr.Close();
                if (sr != null) ns.Close();
                if (connSocket != null) connSocket.Close();
                Monitor.Exit(keyObj);
            }
        }

        static void sendAllMsg(String strMsg, Socket exceptionSocket)
        {
            Monitor.Enter(keyObj);
            foreach(Socket socket in socketList)
            {
                if(socket != exceptionSocket)
                {
                    NetworkStream ns = new NetworkStream(socket);
                    StreamWriter sw = new StreamWriter(ns);
                    sw.WriteLine(strMsg);
                    sw.Flush();
                }
            }
            Monitor.Exit(keyObj);
        }
    }
}
