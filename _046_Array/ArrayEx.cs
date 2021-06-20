using System;

namespace _46_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // 1차원 배열
            int[] numArr = { 19, 29, 33, 54, 64 };
            int[] numArr1 = new int[5];
            for (int i = 0; i < numArr1.Length; i++)
                numArr1[i] = rand.Next(100); // 0 ~ 99

            for (int i = 0; i < numArr.Length; i++)
                Console.Write(numArr[i] + " ");
            Console.WriteLine();
            for(int i = 0; i< numArr1.Length; i++)
                Console.Write(numArr1[i] + " ");
            Console.WriteLine();
        }
    }
}
