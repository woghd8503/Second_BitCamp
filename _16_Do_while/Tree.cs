using System;

namespace _16_Do_while
{
    class Tree
    {
        static void Main(string[] args)
        {
            int num = 0;
            do{
                ++num;
                Console.WriteLine("나무를 {0}번 찍었습니다.", num);
            }
            while(num < 10);
        }
    }
}
