using System;

namespace _10_while
{
    class Tree
    {
        static void Main(string[] args)
        {
            int num = 0;

            /*
             * 대입연산자(=) 기준으로
             * 변수공간 = 변수(공간의 값) + 1
             * ++num => num = num + 1
             */
            while(num < 100)
            {
                Console.WriteLine("나무를 {0}번 찍었습니다.", ++num);
            } 
        }
    }
}
