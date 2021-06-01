using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Homework_0524
{
//1. 중화요리집을 임의대로 클래스로 자유롭게 만드세요

//2. 학생이 아침에 일어나서 준비하고
//   공부하다 가는 일과를 클래스로 자유롭게 만드세요.
    class HomeWork4
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
                    case 6:
                        Q6();
                        break;
                    case 7:
                        Q7();
                        break;
                    case 8:
                        Q8();
                        break;
                    case 9:
                        Q9();
                        break;
                    case 10:
                        Q10();
                        break;
                    case 11:
                        Q11();
                        break;
                    case 12:
                        Q12();
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
    }
}

