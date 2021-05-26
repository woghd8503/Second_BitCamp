using System;

namespace _50_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            int[][] numArr = new int[4][];
            numArr[0] = new int[2];
            numArr[1] = new int[3];
            numArr[2] = new int[2];
            numArr[3] = new int[4];
            int cnt = 0;
            for(int i = 0; i < numArr.Length; i++)
            {
                for(int j = 0; j < numArr[i].Length; j++)
                {
                    numArr[i][j] = cnt++;
                }
            }
            for (int i = 0; i < numArr.Length; i++)
            {
                for (int j = 0; j < numArr[i].Length; j++)
                {
                    Console.Write("{0,2} ", numArr[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
