using System;

namespace _24_Array
{
    class ArrayEx
    {
        static void Main(string[] args)
        {
            // 배열(Array) : 같은 타입의 값을 여러 개 묶어서 관리
            // int요소로 이루어진 배열
            int[] nums = { 33, 22, 11, 99, 88 };

            for (int i = 0; i < nums.Length; i++)
                Console.Write(nums[i] + " ");
        }
    }
}
