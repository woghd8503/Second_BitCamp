using System;

namespace _47_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            int[,] numArr = new int[4, 3];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numArr[i, j] = i * 3 + j;
                    Console.Write("{0,2} ", numArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
