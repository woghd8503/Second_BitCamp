using System;

namespace _18_For
{
    /*    [반복문]
        언제부터(시작)
        어디까지(종료)
        어떻게(1씩 증가, 2씩 증가...)*/
    class Tree
    {
        static void Main(string[] args)
        {
            int num = 0;        // 1) 초기값
            while (num < 10)    // 2) 종료값(종료조건)
            {
                ++num;          // 3) 증감식
                Console.WriteLine("나무가 {0}번 쿵", num);
            }

            Console.WriteLine();
            num = 1;             // 1) 초기값
            for (; num <= 10;)   // 2) 종료값(종료조건)
            {
                Console.WriteLine("나무가 {0}번 쿵", num);
                ++num;          // 3) 증감식
            }

            Console.WriteLine();
            // 1) 초기값 2) 진행조건 3) 증감식
            for (num = 1; num <= 10; ++num)
            {
                Console.WriteLine("나무가 {0}번 쿵", num);
            }
        }
    }
}
