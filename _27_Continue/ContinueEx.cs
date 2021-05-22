using System;

namespace _27_Continue
{
    class ContinueEx
    {
        static void Main(string[] args)
        {
/*            int i = 1;
            while(1 <= 100)
            {
                Console.Write(i + " ");
                i++;
            }*/

            int i = 0;
            while (i <= 100)
            {
                i++;

                if (i % 2 == 0) // 짝수라면
                    continue;   // 앞으로 돌아가서 시작

                Console.Write(i + " ");
            }
        }
    }
}
