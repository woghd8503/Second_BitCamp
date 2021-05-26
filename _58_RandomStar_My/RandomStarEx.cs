using System;
using System.Threading;

namespace _58_RandomStar
{
    class RandomStarEx
    {
        static void Main(string[] args)
        {
            /*100개 배열이나 ArrayList를 이용해서
            100개의 *을 80, 24이내의 임의의 위치에 
            1개씩 출력하고
            역순으로 1개씩 지우기를 반복하라*/

            Random rand = new Random();
            int x = 0, y = 0;
            int[,] numArr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    x = rand.Next(80);
                    y = rand.Next(24);
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.Write("*");
                    if(i % 2 == 0)
                    numArr[i, j] = x;
                    else numArr[i, j] = y;
                    //System.Threading.Thread.Sleep(100);

                    //numArr[i, j] = ;
                }
            }


            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i % 2 == 0)
                         x = numArr[i, j];
                    else y = numArr[i, j];
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
