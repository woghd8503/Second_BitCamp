using System;

namespace _23_For
{
    class gugudan
    {
        static void Main(string[] args)
        {
            for(int i = 2; i <= 9; i++)
            {
                Console.WriteLine();
                Console.Write($"[{i}단]\n");
                for(int j = 1; j <=9; j++ )
                {
                    Console.WriteLine("{0}x{1}={2}", i, j, i * j);
                }
            }
        }
    }
}
