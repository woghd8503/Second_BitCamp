using System;
using System.Net;
using System.IO;
using System.Net.Sockets;

namespace _100_NetworkStreamClient
{
    class Program
    {
        // cmd > ipconfig > ip 주소
        // 접속해야 할 서버의 주소
        // 127.0.0.1 == localhost == 내 호스트(PC) == loop Address
        const string IP = "127.0.0.1"; // 강원랜드 (서버) 주소
        const int PORT = 9000;         // 포커방 주소
        static void Main(string[] args)
        {
            //IPv4: 4 byte 주소
            //IPv6: 16 byte 주소
            //Stream: 연결(컨베이어 벨트 시스템)
            //Dgram: 비연결(택배 시스템, 야구공 던지기)
            //Tcp: 정확한 전송, 실패하면 무조건 다시
            //Udp: 빠른 전송, 실패하면 어쩔 수 없지

            // 1. 서버에 접속할 소켓 생성(휴대폰 구입)
            Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            // 2. 서버의 주소
            IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(IP), PORT);

            // 3. 서버에 접속(후 연결) - 휴대폰 전화걸기
            clientSocket.Connect(ipep);

            // 4. 서버에 데이터 전송
            NetworkStream ns = new NetworkStream(clientSocket);
            StreamWriter sw = new StreamWriter(ns);

            string data = "안녕하세요. 반갑습니다. ^^";
            sw.WriteLine(data);
            sw.Flush();   // 버퍼의 데이터를 즉시 전송 (밀어내다)

            // 5. 접속 종료
            clientSocket.Close(); 
        }
    }
}
