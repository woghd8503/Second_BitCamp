using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

//Main Thread
//    1) 키보드 문자열 입력
//    2) 서버로 전송
//Worker Thread
//    1) 서버로부터 데이터 수신
//    2) 화면 표시
namespace _116_MultiThreadEchoClient
{
    class Program
    {
        const string IP = "127.0.0.1"; // 나자신을 접속한다.
        const int PORT = 9000;
        static void Main(string[] args)
        {
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            clientSocket.Connect(ipep);

            // 서버로부터 데이터 수신을 위한 스레드
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);

            while (true)
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
        static void threadRead(object sock)
        {
            Socket clientSocket = (Socket)sock;
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamReader sr = new StreamReader(ns);
            try
            {
                while (true)
                {
                    string strMsg = sr.ReadLine();
                    Console.WriteLine("[클라이언트] : 수신 : ");
                }
            }catch (Exception e)
            { 
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("[클라이언트] : 서버 접속 종료");
                if (sr != null) sr.Close();
                if (ns != null) ns.Close();
                if (clientSocket != null) clientSocket.Close();
            }
        }
    }
}
