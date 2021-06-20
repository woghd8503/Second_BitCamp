using System;
using System.Collections.Generic;
using System.Text;

namespace _93_Delegate
{
    delegate void sendProg(int nFile);
    class Archive
    {
        public static void korProgress(int nFile)
        {
            Console.WriteLine("{0}번째 패킷을 전송중...", nFile + 1);
        }
        public static void engProgress(int nFile)
        {
            Console.WriteLine("{0} Packet. Wait Please...", nFile + 1);
        }

        public static void sendPacket(int nFile, sendProg prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                prog(i);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    class DelegateEx
    {
        static void Main(string[] args)
        {
            Archive.sendPacket(10, Archive.engProgress);
            Console.WriteLine("모든 패킷을 전송했습니다.");
        }
    }
}
