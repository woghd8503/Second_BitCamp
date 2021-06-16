using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Homework_05_21
{
    class HomeWork1
    {
        //1. 두개의 실수를 입력받고 덧셈 뺄셈 곱셈 나눗셈을  
        //+ - * / 기호를 입력받고 연산결과를 출력하라

        //2. 정수를 입력받고 절대값을 구하라( -5, 5 => 5)

        //3. 미국 인디언들은 1627년에 뉴욕 맨하튼 섬을
        //네덜란드 이주자들에게 단돈 24달러에 팔았다고 합니다.
        //지금 생각하면 헐값에 판 것 같지만,
        //이 돈을 지금까지 은행에 넣어두고
        //8%의 이자를 복리로 받았다면 지금쯤 엄청난 금액이
        //되어 있을 거라고 합니다.
        //2010년을 기준으로 이 돈의 가치가 얼마나 되는지
        //계산하는 프로그램을 작성하세요.
        //복리란 1년이 지날때마다 8%가 원금에 포함이 되어서
        //그 금액이 다시 원금이 되는 것을 말합니다.

        //5. 5를 입력하면
        //*
        //**
        //***
        //****
        //*****
        //이렇게 출력하세요.

        //6. 5를 입력하면
        //*****
        //****
        //***
        //**
        //*
        //이렇게 역순으로 출력하세요.
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
            Console.WriteLine("\n\t1. 두개의 실수를 입력 (사칙연산 기호를 입력 연산결과를 출력)");
            Console.WriteLine("--------------------------------------------------------------------------------");

            decimal[] input = new decimal[2];
            int count = 2;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{i + 1}번째 실수를 입력: ");
                input[i] = decimal.Parse(Console.ReadLine());
            }

            Console.Write("사칙연산할 기호를 입력하시오 [보기 + - * /]: ");
            char symbol = char.Parse(Console.ReadLine());
            Console.Write("\n연산 결과: ");

            switch (symbol)
            {
                case '+':
                    Console.WriteLine($"{input[0]} + {input[1]} = {input[0] + input[1]}");
                    break;
                case '-':
                    Console.WriteLine($"{input[0]} - {input[1]} = {input[0] - input[1]}");
                    break;
                case '*':
                    Console.WriteLine($"{input[0]} * {input[1]} = {input[0] * input[1]}");
                    break;
                case '/':
                    Console.WriteLine($"{input[0]} / {input[1]} = {input[0] / input[1]}");
                    break;
                default:
                    Console.WriteLine("잘못 입력하셨습니다.");
                    break;
            }
        }

        private static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t2. 정수를 입력받고 절대값을 구하라( -5, 5 => 5)");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());

            if (input < 0)
                input = -input;
            Console.WriteLine("결과값: {0}", input);
        }

        private static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. 미국 인디언들은 1627년에 뉴욕 맨하튼 섬을");
            Console.WriteLine("\n\t   네덜란드 이주자들에게 단돈 24달러에 팔았다고 합니다.");
            Console.WriteLine("\n\t   지금 생각하면 헐값에 판 것 같지만, 이 돈을 지금까지 은행에 넣어두고");
            Console.WriteLine("\n\t   8%의 이자를 복리로 받았다면 지금쯤 엄청난 금액이");
            Console.WriteLine("\n\t   되어 있을 거라고 합니다.");
            Console.WriteLine("\n\t   2010년을 기준으로 이 돈의 가치가 얼마나 되는지");
            Console.WriteLine("\n\t   계산하는 프로그램을 작성하세요.");
            Console.WriteLine("\n\t   복리란 1년이 지날때마다 8%가 원금에 포함이 되어서");
            Console.WriteLine("\n\t   그 금액이 다시 원금이 되는 것을 말합니다.");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int gapYears = 2010 - 1627;
            double rate = 1.08;
            double money = 24;
            for(int i = 0; i < gapYears; i++)
            {
                money = money * rate;
            }
            Console.WriteLine("총 금액:" + money + "달러"); 
        }

        private static void Q4()
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

        private static void Q5()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("\n\t5. 5를 입력하면");
            Console.Write("\n\t     *");
            Console.Write("\n\t     **");
            Console.Write("\n\t     ***");
            Console.Write("\n\t     ****");
            Console.WriteLine("\n\t     *****");
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i <= input; ++i)
            {
                for(int j = 0; j < i; ++j)
                Console.Write("*");
                Console.WriteLine();
            }
        }

        private static void Q6()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("\n\t6. 5를 입력하면");
            Console.Write("\n\t     *****");
            Console.Write("\n\t     ****");
            Console.Write("\n\t     ***");
            Console.Write("\n\t     **");
            Console.WriteLine("\n\t     *");
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < input; ++i)
            {
                for (int j = input; j > i; --j)
                    Console.Write("*");
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
