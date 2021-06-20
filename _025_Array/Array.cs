using System;

namespace _25_Array
{
    class Array
    {
        static void Main(string[] args)
        {
            // 배열(Array) : 같은 타입의 값을 여러 개 묶어서 관리
            // int요소로 이루어진 배열
            int[] nums = { 33, 22, 11, 99, 88 };
            int sum = 0;
            int avg = 0;

            // 배열 요소 거꾸로 전체 출력
            for (int i = nums.Length -1; i >= 0; i--)
                Console.Write(nums[i] + " ");
            
            // 배열의 총합과 평균을 구하세요
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                avg = sum / nums.Length;
            }
            Console.WriteLine("\n총합은: {0}", sum);
            Console.WriteLine($"평균값은: {avg}");

            /* [형변환의 규칙]
             * 서로 다른 자료형끼리 연산할 때 적용되는 규칙
             * 'a' + 10 => int로 변환
             * char(2byte) + int(4byte) => 
             * 정수 + 실수 => (표현범위가 무한대)
             */

            // 배열의 실수 평균 구하기
            // 정수중 1개를 실수로 변경하면 돼
            double dAvg = (double)sum / nums.Length;
            Console.WriteLine($"평균값은: {dAvg}");
        }
    }
}
