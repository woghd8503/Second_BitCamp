using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Homework_05_21
{
    public class HomeWork
    {
        //1. 양의 정수를 입력받고 그 수만큼 "감사합니다"를 출력하세요

        //2. 양의 정수 입력받고 그 수만큼 3의 배수 출력하세요
        //예를 들어 5를 입력받으면 3 6 9 12 15를 출력하면 됩니다

        //3. 입력받은 숫자의 구구단을 출력하세요
        //예를 들어 3을 입력하면 
        //3 x 1 = 3
        //3 x 2 = 6
        //...
        //3 x 9 = 27

        //4. 사용자로부터 정수를 입력받습니다.
        //입력 받은 값을 계속 더합니다
        //사용자가 0을 입력하면 합을 출력합니다
        //프로그램을 종료합니다.

        //5. 구구단을 출력하되 1을 입력하면 홀수단만
        //2를 입력하면 짝수단만 출력하라

        //6. 0부터 1씩 증가한 값을 누적하여 더합니다.
        //모두 더한값이 1000이 넘을 때 의 총합과
        //더한 값을 구하세요.

        //7. 두 수를 입력받고 최소공배수를 구하세요.

        //8. 입력받은 숫자의 구구단을 출력하는데 역순으로 출력
        //예) 3*9=27
        //    3*8=24...

        //9. 정수 n을 입력받고 n!을 구하세요.(factorial)
        //5를 입력한경우 1*2*3*4*5를 구하세요.
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
            Console.WriteLine("\n\t1. 양의 정수를 입력받고 그 수만큼 \"감사합니다\" 를 출력하세요");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < input; ++i)
            {
                Console.WriteLine("\t{0}번째 감사합니다.", i + 1);
            }
        }

        private static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t2. 양의 정수 입력받고 그 수만큼 3의 배수 출력하세요\n\t예를 들어 5를 입력받으면 3 6 9 12 15를 출력하면 됩니다");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0, j = 3; i < input; ++i, j += 3)
            {
                if (i == (input - 1))
                    Console.Write($"{j}");
                else Console.Write($"{j}" + ", ");
            }
            Console.WriteLine();
        }

        private static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. 입력받은 숫자의 구구단을 출력하세요\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= 9; ++i)
            {
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }
            Console.WriteLine();
        }

        private static void Q4()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t4. 사용자로부터 정수를 입력 \n\t   입력 받은 값을 계속 더합니다 \n\t   사용자가 0을 입력하면 합을 출력합니다\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int input = 0, sum = 0;
            Console.WriteLine();

            while(true)
            {
                Console.Write("양의정수를 입력: ");
                input = Int32.Parse(Console.ReadLine());
                sum += input;
                if (input == 0)
                    break;
            }
            Console.WriteLine($"사용자가 입력한 총합은: {sum}");
            Console.WriteLine();
        }

        private static void Q5()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t 5. 구구단을 출력\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("1 (홀수단) 또는 2 (짝수단)를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            int i = 0;
            Console.WriteLine();

            if (input == 1)
                i = 1;
            else if (input == 2)
                i = 2;

            for (; i <= 9; i += 2)
            {
                for (int j = 1; j <= 9; ++j)
                { 
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j); 
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        private static void Q6()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t6. 0부터 1씩 증가한 값을 누적\n\t   모두 더한값이 1000이 넘을 때의 (1)총합 과 (2)더한 값은?\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine();
            int sum = 0, i = 0;

            for(; sum < 1000; ++i)
            {
                sum += i;
            }

            Console.WriteLine($"총합:{sum} 더한 값:{i}");
            Console.WriteLine();
        }

        private static void Q7()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t7. 두 수를 입력받고 최소공배수를 구하세요.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[] input = new int[2];
            int max = 0;

            for(int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i+1}번째 숫자를 입력:");
                input[i] = Int32.Parse(Console.ReadLine());
            }

            if (input[0] < input[1])
                max = input[1];
            else max = input[0];

            for (; true; max++)
            {
                if (max % input[0] == 0 && max % input[1] == 0)
                    break;
            }
            Console.WriteLine("최소공배수는: " + max);
        }

        private static void Q8()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t8. 입력받은 숫자의 구구단을 출력하는데 역순으로 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 9; i >= 1; --i)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
            }
            Console.WriteLine();
        }

        private static void Q9()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t9. 정수 n을 입력받고 n!을 구하세요.(factorial)");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            int result = 1;

            for(int i = 1; i <= input; i++)
            {
                result *= i;
            }
            Console.WriteLine("입력하신 n!값은:{0}", result);
        }

        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
