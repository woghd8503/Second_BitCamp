using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Character
{
    
    class HomeWork3
    {

        static void Main()
        {
            /*            // 1번 문제
                        while (true)
                        {
                            string str;
                            Console.WriteLine(" 1. 영문자를 입력받습니다 소문자인지 대문자인지 판별하세요\n(조건 연산자를 사용하세요 종료 : 0 을 누르시오)");
                            Console.Write("영문자를 입력 :");
                            int input = Console.Read();
                            if (input == 48)
                                break;
                            Console.Write("입력할 알파벳은: ");
                            str = input >= 65 && input <= 90 ? "대문자" : (input >= 97 && input <= 122) ? "소문자" : "알파벳이 아닙니다.";
                            Console.WriteLine(str);
                            Console.ReadLine();
                            ClearQuestion();
                        }

                        ClearQuestion();

                        // 2번 문제
                        while (true)
                        {
                            Console.WriteLine(" 2. 영문자를 입력받습니다 소문자인지 대문자인지 판별하세요\n(if문을 사용하세요 종료 : 0 을 누르시오)");
                            Console.Write("영문자를 입력 :");
                            int input = Console.Read();
                            if (input == 48)
                                break;
                            if (input >= 65 && input <= 90)
                                Console.WriteLine("입력하신 알파벳은 대문자입니다.");
                            else if (input >= 97 && input <= 122)
                                Console.WriteLine("입력하신 알파벳은 소문자입니다.");
                            else Console.WriteLine("알파벳이 아닙니다.");
                            Console.ReadLine();
                            ClearQuestion();
                        }

                        ClearQuestion();

                        // 3번 문제
                        while (true)
                        {
                            string str;
                            Console.WriteLine(" 3. 영문자를 입력받습니다. 소문자->대문자로, 대문자->소문자 변경해서 출력하세요 \n(조건 연산자를 사용하세요 종료 : 0 을 누르시오)");
                            Console.Write("영문자를 입력 :");
                            int input = Console.Read();
                            if (input == 48)
                                break;
                            str = input >= 65 && input <= 90 ? "대문자" : (input >= 97 && input <= 122) ? "소문자" : "알파벳이 아닙니다.";
                            input = str == "대문자" ? input + 32 : (str == "소문자") ? input - 32 : input;
                            char result = (char)input;
                            Console.WriteLine("변환된 알파벳은: " + result);
                            Console.ReadLine();
                            ClearQuestion();
                        }

                        ClearQuestion();

                        // 4번 문제
                        while (true)
                        {
                            Console.WriteLine(" 4. 영문자를 입력받습니다 소문자인지 대문자인지 판별하세요\n(if문을 사용하세요 종료 : 0 을 누르시오)");
                            Console.Write("영문자를 입력 :");
                            int input = Console.Read();
                            if (input == 48)
                                break;
                            if (input >= 65 && input <= 90)
                                input = input + 32;
                            else if (input >= 97 && input <= 122)
                                input = input - 32;
                            else Console.WriteLine("알파벳이 아닙니다.");
                            char result = (char)input;
                            Console.WriteLine("변환된 알파벳은: " + result);
                            Console.ReadLine();
                            ClearQuestion();
                        }

                        ClearQuestion();

                        // 5번 문제
                        while (true)
                        {
                            Console.WriteLine(" 5. 돈의 액수를 입금하세요\n 입금한 돈을 오만원권, 만원권, 오천원권, 천원권, 500원동전, 100원동전, 50원동전, 10원동전, 1원동전 각 몇개로 변환되는지 출력하세요\n출력 개수는 단위가 큰 것 순서로 계산합니다\n(종료 : 0 을 누르시오)");
                            Console.Write("입력할 금액은 :");
                            string moneyb = Console.ReadLine();
                            int money = Convert.ToInt32(moneyb);

                            if (money == 0)
                                break;

                            int a, b, c, d, e, f, g, h, i;

                            a = money / 50000;
                            b = money % 50000 / 10000;
                            c = money % 10000 / 5000;
                            d = money % 5000 / 1000;
                            e = money % 1000 / 500;
                            f = money % 500 / 100;
                            g = money % 100 / 50;
                            h = money % 50 / 10;
                            i = money % 10 / 1;

                            Console.WriteLine("오만원 : " + a + "장");
                            Console.WriteLine("만원 : " + b + "장");
                            Console.WriteLine("오천원 : " + c + "장");
                            Console.WriteLine("천원 : " + d + "장");
                            Console.WriteLine("오백원 : " + e + "장");
                            Console.WriteLine("백원 : " + f + "장");
                            Console.WriteLine("오십원 : " + g + "장");
                            Console.WriteLine("십원 : " + h + "장");
                            Console.WriteLine("일원 : " + i + "장");
                            Console.ReadLine();
                            ClearQuestion();

                        }

                        ClearQuestion();
                        // 6번 문제
                        Console.WriteLine(" 6. 369게임을 작성합니다.\n 1~99까지의 정수를 입력받고 3,6,9중 하나가 있으면 박수짝 을 출력하고 2개가 있으면 박수짝짝을 출력하세요\n 예를 들어 13은 박수짝 36인 경우는 박수짝짝을 출력하면 됩니다.\n(종료 : 0 을 누르시오)");
                        for (int i = 1; i <= 100; i++)
                        {
                            int a = i / 10;
                            int b = i % 10;

                            if ((a == 3 || a == 6 || a == 9) && (b == 3 || b == 6 || b == 9))
                            {
                                Console.WriteLine("박수짝짝");
                            }
                            else if (b == 3 || b == 6 || b == 9)
                            {
                                Console.WriteLine("박수짝");
                            }
                            else
                            {
                                Console.WriteLine(i);
                            }
                        }

                        ClearQuestion();*/
            // 7번 문제
            int[] num = new int[3];
            bool exit = false;

            while (true)
            {
                Console.WriteLine(" 7. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 \n삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (조건 연산자를 사용하세요 \n(종료 : 0 을 누르시오))");
                
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine("{0}번째 숫자를 입력하세요", i + 1);
                    string str = Console.ReadLine();
                    num[i] = Convert.ToInt32(str);
                    if (num[i] == 0)
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit)
                    break;
                string result1 = (num[0] + num[1]) > num[2] && (num[1] + num[2]) > num[0] && (num[2] + num[0]) > num[1] ? "삼각형이 될 수 있습니다." : "삼각형이 될 수 없습니다.";
                Console.WriteLine(result1);
                ClearQuestion();
            }

            ClearQuestion();
            // 8번 문제

            while(true)
            {
                Console.WriteLine("8. 정수 3개를 입력받고 이 3개의 수로 삼각형을 만들 수 있는지를 판별하세요 \n삼각형이 가능하려면 두 변의 합이 다른 한 변의 합보다 반드시 커야 합니다. (if문을 사용하세요 \n(종료 : 0 을 누르시오))");
                exit = false;
                for (int i = 0; i < num.Length; i++)
                {
                    Console.WriteLine("{0}번째 숫자를 입력하세요", i + 1);
                    string str = Console.ReadLine();
                    num[i] = Convert.ToInt32(str);
                    if (num[i] == 0)
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit)
                    break;
                if ((num[0] + num[1]) > num[2] && (num[1] + num[2]) > num[0] && (num[2] + num[0]) > num[1])
                    Console.WriteLine("삼각형이 될 수 있습니다.");
                else Console.WriteLine("삼각형이 될 수 없습니다.");
                ClearQuestion();
            }

            ClearQuestion();
            // 9번 문제

            while (true)
            {
                Console.WriteLine("9. 두개의 정수를 입력받고 몫과 나머지를 출력하세요 \n(종료 : 0 을 누르시오))");
                exit = false;
                int num1 = 0, num2 = 0;

                for (int i = 0; i < 2; i++)
                {
                    Console.WriteLine("{0}번째 숫자를 입력하세요", i + 1);
                    string str = Console.ReadLine();
                    if(i == 0)
                    num1 = Convert.ToInt32(str);
                    if(i == 1)
                    num2 = Convert.ToInt32(str);

                    if (str == "0")
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit)
                    break;
                Console.WriteLine("몫은 :{0}", num1 / num2);
                Console.WriteLine("나머지 값은 :{0}", num1 % num2);
                ClearQuestion();
            }

            ClearQuestion();
            // 10번 문제

            while (true)
            {
                Console.WriteLine("10. 세개의 정수를 입력받고 각각의 수의 제곱을 구해서 모두 더하세요.\n 즉, num1의 제곱+num2의 제곱+num3의 제곱 \n(종료 : 0 을 누르시오))");
                exit = false;
                int[] num3 = new int[3];

                for (int i = 0; i < num3.Length; i++)
                {
                    Console.WriteLine("{0}번째 숫자를 입력하세요", i + 1);
                    string str = Console.ReadLine();
                    num[i] = Convert.ToInt32(str);

                    if (str == "0")
                    {
                        exit = true;
                        break;
                    }
                }
                if (exit)
                    break;
                
                Console.WriteLine("세개 정수의 제곱의 합 :{0}", Math.Pow(num[0], num[0]) + Math.Pow(num[1], num[1]) + Math.Pow(num[2], num[2]));
                ClearQuestion();
            }

            void ClearQuestion()
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
