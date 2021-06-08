using System;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace _100_NetworkStreamClient
{
    class Program
    {
        // cmd > ipconfig > 호스트의 IP

        // 접속해야 할 서버의 주소
        // 127.0.0.1 == localhost == 내 호스트(PC) == loop Address
        const string IP = "127.0.0.1"; // 나자신을 접속한다.

        const int PORT = 9000;
        static void Main(string[] args)
        {
              /*AddressFamily.InterNetwork : IPv4
                SocketType.Stream : 연결지향형 통신
                ProtocolType.Tcp : 테이터의 정확한 전송*/

            // 1. 서버에 접속할 소켓 생성(휴대폰 구입)
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 2. 서버의 주소
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            // 3. 서버에 접속(후 연결)
            clientSocket.Connect(ipep);

            // 4. 서버에 데이터 전송
            //    대기시켜놓는 내부 Queue를 100개 생성
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);

            while(true)
            {
                Console.WriteLine("[클라이언트] 입력 >> ");
                string data = Console.ReadLine();
                sw.WriteLine(data);
                sw.Flush(); // 버퍼의 데이터를 즉시 전송

                if (data == "exit")
                    break;
            }

            // 5. 접속 종료
            clientSocket.Close(); 
        }
    }
}
