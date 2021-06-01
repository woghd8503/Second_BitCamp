using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Homework_0524
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace _003_Homework_0524
    {
        //1. 구구단의 짝수단만 출력하되, 
        //   2단은 2 x 2까지
        //   4단은 4 x 4까지
        //   6단은 6 x 6까지
        //   8단은 8 x 8까지 출력하세요

        //2. 원의 반지름 정보를 전달하면,
        //   원의 넓이를 계산하여 반환하는 메서드와
        //   원의 둘레를 계산하여 반환하는 메서드를 정의하고
        //   main에서 사용하세요

        //3. 전달된 값이 소스(prime number)인지 아닌지 판단하여
        //   소수인 경우는 true를, 소수가 아닌 경우는 false를
        //   반환하는 메서드를 정의하고,
        //   이를 이용해서 1 이상 100이하의 소수를 전부 출력할 수 있도록
        //   main 메서드를 정의하세요.

        //4. showHi(3);
        //    을 입력하면

        //    Hi ~
        //     Hi~
        //     Hi~
        //     회수만큼 Hi ~를 호출할 수 있도록 for문을 사용해서 출력하세요


        //5. showHi(3);
        //    을 입력하면

        //    Hi ~
        //     Hi~
        //     Hi~
        //     회수만큼 Hi ~를 호출할 수 있도록 재귀호출을 사용해서 출력하세요
        class HomeWork3
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
                            Q1;
                            break;
                        case 2:
                            Q2
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
                //1. 구구단의 짝수단만 출력하되, 
                //   2단은 2 x 2까지
                //   4단은 4 x 4까지
                //   6단은 6 x 6까지
                //   8단은 8 x 8까지 출력하세요
                Console.WriteLine("구구단의 짝수단만 출력 ex) 2단은 2 x 2까지");

                for (int i = 0; i < 10; i += 2)
                {
                    for (int j = 0; j < i; j++)
                        Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }

            private static void Q4()
            {
                //4. showHi(3);
                //    을 입력하면

                //    Hi ~
                //     Hi~
                //     Hi~
                //     회수만큼 Hi ~를 호출할 수 있도록 for문을 사용해서 출력하세요
                Console.Write("출력하고 싶은 횟수를 입력: ");
                int input = Int32.Parse(Console.ReadLine());

                ClearScreen();

                void showHi(int i)
                {
                    for (int j = 0; j < i; j++)
                        Console.WriteLine($"{j + 1}번째 Hi ~");
                }
                showHi(input);
            }

            private static void Q5()
            {
                //5. showHi(3);
                //    을 입력하면

                //    Hi ~
                //     Hi~
                //     Hi~
                //     회수만큼 Hi ~를 호출할 수 있도록 재귀호출을 사용해서 출력하세요
                Console.Write("출력하고 싶은 횟수를 입력: ");
                int input = Int32.Parse(Console.ReadLine());

                ClearScreen();

                void showHi(int i)
                {
                    if (i == 0)
                        return;

                    Console.WriteLine("Hi ~");
                    showHi(--i);
                }
                showHi(input);
            }

            static void Main(string[] args)
            {
                SelectQestion();
            }
        }
    }


}
