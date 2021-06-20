using System;
using System.Collections.Generic;
using System.Text;

namespace _93_Delegate
{
    class Archive
    {
        public static void sendPacket(int nFile)
        {
            for (int i = 0; i < nFile; i++)
            {
                Console.WriteLine("{0}번째 패킷을 전송중...", i + 1);
                System.Threading.Thread.Sleep(500);
            }
        }
    }
    class DelegateEx
    {
        static void Main(string[] args)
        {
            Archive.sendPacket(10);
            Console.WriteLine("모든 패킷을 전송했습니다.");
        }
    }
}
