using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Homework_05_21
{
    class HomWork2
    {
        // 1. 5를 입력하면
        // o
        // *o
        // **o
        // ***o
        // ****o
        // 이렇게 출력하세요.


        // 2. 홀수를 입력하면 됩니다.
        // 7를 입력하면
        //    *
        //   ***
        //  *****
        // *******
        //  *****
        //   ***
        //    *
        //이렇게 출력하세요.
        static void Main(string[] args)
        {
            SelectQestion();
        }

        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 <나가기는 10 입력>: ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 10)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }

        private static void Q1()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("\n\t1. 5를 입력하면");
            Console.Write("\n\t     o");
            Console.Write("\n\t     *o");
            Console.Write("\n\t     **o");
            Console.Write("\n\t     ***o");
            Console.WriteLine("\n\t     ****o");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= input - 1; ++i)
            {
                for (int j = 0; j < i; ++j)
                    Console.Write("*");
                Console.Write("o");
                Console.WriteLine();
            }
        }

        private static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("\n\t1. 7를 입력하면");
            Console.Write("\n\t       *");
            Console.Write("\n\t      ***");
            Console.Write("\n\t     *****");
            Console.Write("\n\t    *******");
            Console.Write("\n\t     *****");
            Console.Write("\n\t      ***");
            Console.WriteLine("\n\t       *");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            int half = input / 2;
            Console.WriteLine();

            for (int i = 0; i <= input; i++)
            {
                if (i <= half)
                {
                    for (int j = half; j > i; --j)
                        Console.Write(" ");
                    for (int k = 0; k <= i; ++k)
                        Console.Write("*");
                    for (int m = 1; m <= i; ++m)
                        Console.Write("*");
                }else if(i >= half)
                {
                    for (int j = 0; j < (i - half); ++j)
                        Console.Write(" ");
                    for (int k = half; k > (i - half); --k)
                        Console.Write("*");
                    for(int m = half + 1; m > (i - half); --m)
                        Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
