using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

//Main Thread (전체에서 1개)
//    1) 접속 클라이언트의 Accept 처리
//    2) 클라이언트 담당 스레드 생성 요청 후
//       스레드의 매개변수로 소켓 전달
//Worker Thread(클라이언트 당 1개씩 계속 생성)
//    1) threadRead 메서드의 동작을 수행
//     -클라이언트의 데이터 수신
//     -수신 데이터 화면에 표시
//     -그리고 다시 수신 대기
namespace _114_MultiThreadServer
{
    class Program
    {
        const int PORT = 9000;
        static void Main(string[] args)
        {
            // IPv4, 연결지향형, 신뢰성(정확성)
            // Accept 역할 담당 소켓
            // 휴대폰
            Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine("Hello World!");

            // 주소(현재 Host IP, PORT에 정의된 숫자)
            // 휴대폰에 부여할 전화번호
            IPEndPoint ipep = new IPEndPoint(IPAddress.Any, PORT);

            // 소켓에 주소를  부여(휴대폰 개통)
            serverSocket.Bind(ipep);
            serverSocket.Listen(100); // 이통사와 연결
            Console.WriteLine("[서버] 접속 대기중...");
            while(true)
            {
                Console.WriteLine("[서버] 접속 대기중...");
                // VIPS입구 직원한테 손님이 안내 요청하니까
                // 당담직원 불러서 안내/서비스를 하도록
                // 위임
                // serverSocket : Accept 담당
                // connSocket : Write/Read 담당 (클라이언트 직접 연결)
                Socket connSocket = serverSocket.Accept();
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
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally // 정상, 예외 모두 모조건 최종 실행 되는 구문
            {
                Console.WriteLine("[서버] 클라이언트 접속 종료");
                if (sr != null) sr.Close();
                if (sr != null) ns.Close();
                if (connSocket != null) connSocket.Close();
            }
        }
    }
}
