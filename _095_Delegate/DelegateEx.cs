using System;
using System.Collections.Generic;
using System.Text;

namespace _93_Delegate
{
    delegate bool sendProg(int nFile);

    class Archive
    {
        public static bool sendPacket(int nFile, sendProg prog)
        {
            for (int i = 0; i < nFile; i++)
            {
                if (prog(i) == false)
                    return false;
                System.Threading.Thread.Sleep(500);
            }
            return true;
        }
    }
    class DelegateEx
    {
        public static bool progress(int nFile)
        {
            Console.WriteLine("{0} 번째 패킷 전송중...", nFile + 1);

            if(Console.KeyAvailable) // 키가 눌렸다면
            {
                ConsoleKeyInfo cki = Console.ReadKey(false);
                if (cki.Key == ConsoleKey.Escape)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            if (Archive.sendPacket(10, progress))
                Console.WriteLine("모든 패킷을 전송했습니다.");
            else
                Console.WriteLine("전송이 중단되었습니다.");
        }
    }
}
