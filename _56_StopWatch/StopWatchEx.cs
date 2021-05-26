using System;
using System.Diagnostics;

namespace _56_StopWatch
{
    class StopWatchEx
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();
            for(int i =0; i< 100000; i++)
            {
                Console.Write(i + ", ");
            }
            st.Stop(); // 끝
            Console.WriteLine("\n총 경과 시간 : " + st.Elapsed);
        }
    }
}
