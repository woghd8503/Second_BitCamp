﻿using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace _119_MultiThreadChattingPlusClient
{
    class Menu
    {
        public const int ID = 1;
        public const int CHATTING = 2;
        public const int WHISPER = 3;
        public const int CALC = 4;
        public const int EXIT = 5;
    }
    class CHAT_MODE
    {
        public const int CHATTING = 1;
        public const int WHISPER = 2;
    }
    class Program
    {
        const string IP = "127.0.0.1";
        const int PORT = 9000;

        static string myId = "";
        static string whisperId = "";
        static int chatMode = 0;

        static Socket clientSocket = null;
        static IPEndPoint ipep = null;
        static void Main(string[] args)
        {
            clientSocket = new Socket(AddressFamily.InterNetwork,
                                      SocketType.Stream,
                                      ProtocolType.Tcp);

            ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            clientSocket.Connect(ipep);

            menuLoop();
        }

        static void menuLoop()
        {
            bool isRun = true;
            while (isRun)
            {
                clearScreen();
                showMenu();
                int sel = getSelMenu();
                switch (sel)
                {
                    case Menu.ID:
                        runId(clientSocket);
                        break;
                    case Menu.CHATTING:
                        runChatting(clientSocket);
                        break;
                    case Menu.WHISPER:
                        runWhisper(clientSocket);
                        break;
                    case Menu.CALC:
                        runCalc(clientSocket);
                        break;
                    case Menu.EXIT:
                        runExit(clientSocket);
                        isRun = false;
                        clientSocket.Close();
                        break;
                }
            }
        }

        static void showMenu()
        {
            Console.WriteLine("1. ID 입력");
            Console.WriteLine("2. 채팅");
            Console.WriteLine("3. 귓속말");
            Console.WriteLine("4. 사칙연산");
            Console.WriteLine("5. 종료");
            Console.WriteLine();
        }
        static int getSelMenu()
        {
            Console.Write("select Menu >> ");
            int sel = Int32.Parse(Console.ReadLine());
            return sel;
        }
        static void clearScreen()
        {
            Console.Clear();
        }
        /*
        서버와 클라이언트는 업무를 처리하기 위해
        패킷을 설계하고 주고받아야 한다.
        [구분자 패킷]
        1) 3가지 요소로 구성
        2) 명령어, 구분자(|), 데이터
        3) 패킷 설계
            a) id입력
               I|gildong
            b) 채팅 데이터
               C|E    - 채팅가능 여부
                 C|O    - 채팅 가능
                 C|F    - 채팅 불가능
               C|M|안녕하세요
            c) 귓속말
               W|E    - 귓속말가능 여부
                 W|O    - 귓속말 가능
                 W|F    - 귓속말 불가능
               W|L    - 귓속말 가능 ID 목록
               W|M|jang|감사합니다
            d) 사칙연산
               A|+|10|20
               A|-|100|200
               A|*|10|5
               A|/|10|3
               A|%|10|3
            e) 종료
               E|
        */
        static void runId(Socket clientSocket)
        {
            Console.Write("ID 입력하세요 >> ");
            String id = Console.ReadLine();
            myId = id;      // static 멤버로 id를 기억해 놓음

            String packet =
                String.Format("I|{0}", id);

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(packet);
            sw.Flush();
        }

        static void runChatting(Socket clientSocket)
        {
            String packet = "C|E";

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.WriteLine(packet);
            sw.Flush();
            String response = sr.ReadLine();
            String[] dataArr = response.Split(new char[] { '|' });
            String mainCmd = dataArr[0];
            String subCmd = dataArr[1];
            if (mainCmd == "C")
            {
                if(subCmd == "O")
                {
                    chatMode = CHAT_MODE.CHATTING;
                    Thread thread = new Thread(new ParameterizedThreadStart(threadRead));
                    thread.Start(clientSocket);

                    while (true)
                    {
                        Console.WriteLine("[exit]는 채팅 종료 >>>>>>>>>> ");
                        String msg = Console.ReadLine();
                        if (msg == "[exit]")
                            break;
                        packet = String.Format("C|M|{0}", msg);
                        sw.WriteLine(packet);
                        sw.Flush();
                    }
                    /*
                    threadRead를 담당하는 Worker Thread의
                    예외발생을 위해서(스레드 종료하기 위해)
                    */
                    clientSocket.Close();
                }
                else if(subCmd == "F")
                {
                    Console.WriteLine("id를 입력해야 채팅이 가능합니다\n");
                    Console.ReadKey();
                }
            }
        }

        static void runWhisper(Socket clientSocket)
        {
            String packet = "W|E";

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.WriteLine(packet);
            sw.Flush();
            String response = sr.ReadLine();
            String[] dataArr = response.Split(new char[] { '|' });
            String mainCmd = dataArr[0];
            String subCmd = dataArr[1];
            if (mainCmd == "W")
            {
                if (subCmd == "O")
                {
                    packet = "W|L"; 
                    sw.WriteLine(packet);
                    sw.Flush();

                    packet = sr.ReadLine();
                    dataArr = packet.Split(new char[] { '|' });
                    mainCmd = dataArr[0];
                    subCmd = dataArr[1];
                    if (mainCmd == "W" && subCmd == "L")
                    {
                        Console.WriteLine("---ID 리스트---");
                        for (int i = 2; i < dataArr.Length; i++)
                            Console.WriteLine(dataArr[i]);
                        Console.WriteLine();

                        Console.Write("whisper id 입력 >> ");
                        whisperId = Console.ReadLine();
                        whisperId = selectWhisperId(dataArr, whisperId);
                        if (whisperId != "")
                        {
                            chatMode = CHAT_MODE.WHISPER;
                            Thread thread = new Thread(new ParameterizedThreadStart(threadRead));
                            thread.Start(clientSocket);

                            while (true)
                            {
                                Console.WriteLine("[exit]는 채팅 종료 >>>>>>>>>> ");
                                String msg = Console.ReadLine();
                                if (msg == "[exit]")
                                    break;
                                else if (msg == "!")
                                {
                                    Console.Write("몇회 전송 >> ");
                                    int cnt = Int32.Parse(Console.ReadLine());
                                    Console.Write("문장은 >> ");
                                    msg = Console.ReadLine();
                                    for(int i = 0; i < cnt; i++)
                                    {
                                        packet = String.Format("W|M|{0}|{1} [{2}]", whisperId, msg, i+1);
                                        sw.WriteLine(packet);
                                        sw.Flush();
                                        Thread.Sleep(100);
                                    }
                                }
                                else
                                {
                                    packet = String.Format("W|M|{0}|{1}", whisperId, msg);
                                    sw.WriteLine(packet);
                                    sw.Flush();
                                }                              
                                
                            }
                            /*
                            threadRead를 담당하는 Worker Thread에
                            강제로 예외를 발생시키기 위해
                            소켓을 닫아준다
                            그러면 threadRead내의 while(true)내의
                            sr.ReadLine()에서 예외가 발생해서
                            스레드가 종료된다
                            */
                            clientSocket.Close();
                        }
                        else
                        {
                            Console.WriteLine("선택한 id가 잘못되었습니다");
                        }
                    }
                }                
                else if (subCmd == "F")
                {
                    Console.WriteLine("id를 입력해야 채팅이 가능합니다\n");
                    Console.ReadKey();
                }
            }
        }

        static string selectWhisperId(string[] idArr, string selectId)
        {
            string sel = "";
            foreach(string id in idArr)
            {
                if(id == selectId)
                {
                    sel = selectId;
                    break;
                }
            }

            return sel;
        }

        static void runCalc(Socket clientSocket)
        {
            Console.Write("1번째 숫자 입력 : ");
            string num0 = Console.ReadLine();
            Console.Write("2번째 숫자 입력 : ");
            string num1 = Console.ReadLine();
            Console.Write("연산자 입력 (+ - * / %) : ");
            string op = Console.ReadLine();
            String packet = String.Format("A|{0}|{1}|{2}", op, num0, num1);

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            StreamReader sr = new StreamReader(ns);
            sw.WriteLine(packet);
            sw.Flush();
            String response = sr.ReadLine();
            String[] dataArr = response.Split(new char[] { '|' });
            String mainCmd = dataArr[0];

            switch (mainCmd)
            {
                case "A":
                    Console.WriteLine("result = " + dataArr[1]);
                    Console.ReadKey();
                    break;
            }
        }

        static void runExit(Socket clientSocket)
        {
            String packet = "E|";

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(packet);
            sw.Flush();
        }

        static void processChat(string msg)
        {
            string[] dataArr = msg.Split(new char[] { '|' });
            string mainCmd = dataArr[0];
            string subCmd = dataArr[1];

            switch (mainCmd)
            {
                case "C":
                    if (subCmd == "M")
                    {
                        Console.WriteLine(dataArr[2]);
                    }
                    break;
                case "W":
                    if (subCmd == "M")
                    {
                        Console.WriteLine(dataArr[2]);
                    }
                    break;
            }
        }

        static void threadRead(object sock)
        {
            Socket clientSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader sr = new StreamReader(ns);

            try
            {
                while (true)
                {
                    String strMsg = sr.ReadLine();
                    processChat(strMsg);
                    //Console.WriteLine("[클라이언트] :  수신 : " + strMsg);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("[클라이언트] : 채팅 종료");
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (clientSocket != null) clientSocket.Close();

                reConnectById();
            }
        }

        static void reConnectById()
        {
            clientSocket = new Socket(AddressFamily.InterNetwork,
                             SocketType.Stream,
                             ProtocolType.Tcp);

            ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            clientSocket.Connect(ipep);

            String packet = String.Format("I|{0}", myId);

            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);
            sw.WriteLine(packet);
            sw.Flush();

            //Console.WriteLine();
            //showMenu();
            //Console.Write("select Menu >> ");
        }
    }
}
