using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Homework_0524
{
//1. 8 x 9 이차원 배열을 선언하세요

//2. 8 x 9 이차원 배열에 구구단의 결과값을 대입하세요

//3. 2번에 대입한 값을 출력하세요

//4. 7개의 float 배열을 할당하세요
//   앞의 5개에는 성적을 입력받고
//   6번째는 총점
//   7번째는 평균을 계산해서 넣으세요
   
//5. 4번을 출력하세요
    class HomeWork2
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 0)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    case 4:
                        Q4();
                        break;
                    case 5:
                        Q5();
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
            Console.WriteLine("\n\t1. 정수 10개를 입력받아 배열에 저장 \n\t   이 정수중에서 3의 배수만 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 양의정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                    Console.WriteLine("\t 입력하신 숫자중 3의 배수는: {0}", input[i]);
            }
        }
        private static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 정수 10개를 입력받아 배열에 저장 \n\t   이 정수중에서 3의 배수만 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 양의정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                    Console.WriteLine("\t 입력하신 숫자중 3의 배수는: {0}", input[i]);
            }
        }
        private static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 정수 10개를 입력받아 배열에 저장 \n\t   이 정수중에서 3의 배수만 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 양의정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                    Console.WriteLine("\t 입력하신 숫자중 3의 배수는: {0}", input[i]);
            }
        }
        private static void Q4()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 정수 10개를 입력받아 배열에 저장 \n\t   이 정수중에서 3의 배수만 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 양의정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                    Console.WriteLine("\t 입력하신 숫자중 3의 배수는: {0}", input[i]);
            }
        }
        private static void Q5()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 정수 10개를 입력받아 배열에 저장 \n\t   이 정수중에서 3의 배수만 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[10];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 양의정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 3 == 0)
                    Console.WriteLine("\t 입력하신 숫자중 3의 배수는: {0}", input[i]);
            }
        }
    }
}
