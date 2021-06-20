using System;

namespace _26_Break
{
    class BreakEx
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            while (true)
            {
                Console.Write("주사위 값: ");
                // 0~5까지 임의의 수 + 1 => 1~6
                int num = rand.Next(6) + 1;
                Console.WriteLine(num);
                if (num == 3)
                    break; // 반복문(loop)을 강제 탈출

                // 1초간 멈춘다.
                System.Threading.Thread.Sleep(1000);
            }
            Console.WriteLine("탈출했습니다.");
        }
    }
}
