using System;

namespace _32_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            // 배열의 선언
            int[] ar;           // int배열을 담겠다.
            ar = new int[5];    // int배열을 5개 할당

            for (int i = 0; i < ar.Length; i++)
                ar[i] = i * 2;
            for (int i = 0; i < ar.Length; i++)
                Console.WriteLine(ar[i]);
        }
    }
}
