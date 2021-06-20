using System;

namespace _48_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            //기본배열이 9개짜리가 8층인 2차원 배열
            int[,] gugudanArr = new int[8, 9];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    gugudanArr[i, j] = (i + 2) * (j + 2);
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("{0,2} ", gugudanArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
