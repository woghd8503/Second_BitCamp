using System;
using System.Linq;

namespace _003_Homework_0524
{
    //1. 정수 10개를 입력받아 배열에 저장하고, 이 정수중에서 3의 배수만 출력하세요

    //2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드를 만들고 사용하는 프로그램을 작성하세요

    //3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와
    //   작은 값을 반환하는 메서드를 작성하고 사용하세요

    //4. 20개 배열을 선언하세요
    //    20개의 값을 난수를 이용해서 0 ~ 100까지의 값으로 채워넣고
    //    먼저 인덱스의 홀수번째는 앞에서부터 출력하고
    //    짝수번째는 뒤에서부터 출력하세요

    //5. AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구하는 프로그램을 작성하세요

    //6. 0~99까지 임의의 수를 생성합니다
    //   사용자로부터 숫자를 입력받습니다
    //   사용자가 임의의 수보다 낮은 값을 입력하면 "더 높게"를 출력하고
    //   높은 값을 입력하면 "더 낮게"를 출력합니다
    //   정답을 맞추면 "맞았습니다"를 출력합니다.
    //   y/n을 묻고 y를 입력하면 다시 게임을 진행하고
    //   n을 입력하면 종료합니다

    //7. 두 개의 정수를 입력받습니다.
    //   두 정수를 포함한 사이의 정수의 합을 출력하세요
    //   예를 들면 3과 5를 입력하면 3+4+5의 합을 출력하면 됩니다.

    //8. /* 영문자와 숫자를 입력받고
    //   * "대문자", "소문자", "숫자"를
    //   * 판단하는 메서드를 제작하고
    //   * 사용해보세요
    //   * 아스키코드테이블 참조
    //   * */

    //9. 두 수를 입력받고 최대 공약수를 출력하세요

    //10. 전달된 값이 소수인지 아닌지 판단하여, 소수인 경우 true를, 소수가 아닌 경우 false를 반환하는 메서드를 정의하고
    //이를 이용해서 1이상 100이하의 소수가 전부 출력할 수 있도록 코드를 구성하세요
    //소수는 1외에 자기자신으로만 나뉘어지는 수입니다

    //11. 구구단을 출력하세요
    //2x1= 2 3x1= 3 4x1= 4... 9x1= 9
    //2x2= 4 3x2= 6 4x2= 8... 9x2= 18...
    //2x9= 18 3x9= 27 4x9= 36... 9x9= 81

    //12. 세개의 정수를 매개변수로 받아서
    //  가장 큰 수를 반환하는 메서드와
    //  가장 작은 수를 반환하는 메서드를 제작해서 사용해보세요

    //13. 사용자로부터 초를 입력받은 후
    //  이 초를 [시간, 분, 초] 로 출력하는 메서드를 제작해서
    //  사용해보세요
    //  예를 들어 3672를 입력하면 [1시간, 1분, 12초]를
    //  출력하면 됩니다.
    class HomeWork
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
                    case 13:
                        Q13();
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
            Console.WriteLine("\n\t2. 1부터 10까지 곱해서 그 결과를 출력하는 메서드 구현");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n[결과 값]\n");

            int Mul(int _sum = 1)
            {
                for (int i = 1; i <= 10; i++)
                    _sum *= i;
                return _sum;
            }
            int sum = Mul();

            Console.WriteLine($"결과값: {sum}");
        } 
        private static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. 2개의 정수를 입력받고 큰 값을 반환하는 메서드와");
            Console.WriteLine("\n\t  작은 값을 반환하는 메서드를 작성하고 사용하세요");
            Console.WriteLine("--------------------------------------------------------------------------------");
            
            Console.Write("첫 번재 양의정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.Write("두 번재 양의정수를 입력: ");
            int input1 = Int32.Parse(Console.ReadLine());
            
            int CalMax(int input, int input1)
            {
                int max = 0;
                max = input < input1 ? input1 : input;
                return max;
            }

            int CalMin(int input, int input1)
            {
                int min = 0;
                min = input < input1 ? input : input1;
                return min;
            }

            Console.WriteLine("\n[결과 값]\n");
            Console.WriteLine($"최대 수:{CalMax(input, input1)} 최소 수: {CalMin(input, input1)}");
        }
        private static void Q4()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t4. 20개 배열을 선언, 20개의 값을 난수를 이용해서 \n\t   0 ~ 100까지의 값 (홀수 -> 짝수)출력");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n[결과 값]\n");

            int[] arr = new int[20];
            Random r = new Random();

            for (int i = 0; i < arr.Length; ++i)
            {
                arr[i] = r.Next(0, 100);
            }

            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 != 0)
                    Console.Write($"{arr[i]}" + ", ");
            }
            Console.Write("| "); // 기준점
            for (int i = 0; i < arr.Length; ++i)
            {
                if (arr[i] % 2 == 0)
                    Console.Write($"{arr[i]}" + ", ");
            }
        }
        private static void Q5()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t5. AB + BA = 99 를 만족하는 모든 A와 B의 조합을 구함");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.WriteLine("\n[결과 값]\n");
            for (int A = 0; A < 10; A++)
            {
                for (int B = 0; B < 10; B++)
                {
                    if ((A * 10 + B) + (B * 10 + A) == 99)
                        Console.WriteLine($"{A}{B} + {B}{A} = {(A * 10 + B) + (B * 10 + A)}");
                    if ((B * 10 + A) + (A * 10 + B) == 99)
                        Console.WriteLine($"{B}{A} + {A}{B} = {(B * 10 + A) + (A * 10 + B)}");
                }
            }
        }
        private static void Q6()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t6. 0~99까지 임의의 수(정답)를 생성합니다");
            Console.WriteLine("\n\t사용자로부터 숫자를 입력받습니다");
            Console.WriteLine("\n\t임의의 수 < 정답 \"더 높게↑\"를 출력");
            Console.WriteLine("\n\t임의의 수 > 정답 \"더 낮게↓\"를 출력");
            Console.WriteLine("\n\t임의의 수 == 정답 \"★맞았습니다★\"를 출력");
            Console.WriteLine("\n\t게임 진행여부(Y/N)");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Random r = new Random();

            Console.WriteLine();
            while (true)
            {
                int answer = r.Next(0, 99);

                Console.Write("임의의 수 를 입력: ");
                int input = Int32.Parse(Console.ReadLine());

                string result = input < answer ? "더 높게↑" : input == answer ? "★맞았습니다★" : "더 낮게↓";
                Console.WriteLine($"난수: {answer}, {result} \n");

                Console.WriteLine("계속 진행하시겠습니까? (Y/N)");
                string decision = Console.ReadLine();

                if (decision == "Y" || decision == "y")
                    continue;
                else if (decision == "N" || decision == "n")
                    break;
            }
        }
        private static void Q7()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t7. 두 개의 정수를 입력받습니다.\n\t   두 정수를 포함한 사이의 정수의 합을 출력하세요\n\t   예를 들면 3과 5를 입력하면 3+4+5의 합을 출력하면 됩니다.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("첫번째 정수를 입력: ");
            int input = Int32.Parse(Console.ReadLine());
            Console.Write("두번째 정수를 입력: ");
            int input1 = Int32.Parse(Console.ReadLine());
            int max = 0, min = 0, sum = 0;

            if (input < input1)
            {
                max = input1; min = input;
            }
            else
            {
                max = input; min = input1;
            }

            for (int i = min; i <= max; i++)
            {
                sum += i;
            }

            Console.WriteLine("\n[결과 값]\n");
            Console.WriteLine("from: {0} to: {1} total sum: {2}", min, max, sum);
        }
        private static void Q8()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t8. 영문자와 숫자를 입력받고");
            Console.WriteLine("\n\t \"대문자\", \"소문자\", \"숫자\"를");
            Console.WriteLine("\n\t   판단하는 메서드 제작");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.Write("입력: ");
            char input = char.Parse(Console.ReadLine());
            Console.WriteLine();

            if(input >= 65 && input <= 90)
                    Console.WriteLine("대문자");
            else if (input >= 97 && input <= 122)
                    Console.WriteLine("소문자");
            else if (input >= 48 && input <= 57)
                    Console.WriteLine("숫자");
        }
        private static void Q9()
        {
                ClearScreen();
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("\n\t9. 두 수를 입력받고 최대 공약수를 출력하세요");
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("첫 번재 양의정수를 입력: ");
                int input = Int32.Parse(Console.ReadLine());
                Console.Write("두 번재 양의정수를 입력: ");
                int input1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine();
                int result = formula(input, input1);

                Console.WriteLine("두수의 최대 공약수는{0}", result);

                int formula(int num, int num1)
                {
                    int num2 = 0;
                    while (num1 != 0)
                    {
                        num2 = num % num1;
                        num = num1;
                        num1 = num2;
                    }
                    return num;
                }
        }
        private static void Q10()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t10. 0 ~ 100 까지 전달된 값이 소수인지 아닌지 판단 후 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            bool FindPrimeNum(int num)
            {
                if (num <= 1)
                    return false;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                        return false;
                }
                return true;
            }

            for (int i = 1; i <= 100; i++)
            {
                if (FindPrimeNum(i) == true)
                Console.Write( i + ", ");
            }
        }
        private static void Q11()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t11. 구구단을 출력하세요");
            Console.WriteLine("--------------------------------------------------------------------------------");
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
                Console.WriteLine();
            }
        }
        private static void Q12()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n   12. 세개의 정수를 매개변수로 받은 후 max 와 min 을 반환하는 메서드 제작");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[] input = new int[3];

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{i + 1}번째 정수를 입력: ");
                input[i] = Int32.Parse(Console.ReadLine());
            }

            int CalMax(int num1, int num2, int num3)
            {
                int max = 0;

                if (num1 > num2 && num1 > num3)
                    max = num1;
                if (num2 > num1 && num2 > num3)
                    max = num2;
                if (num3 > num1 && num3 > num2)
                    max = num3;

                return max;
            }

            int CalMin(int num1, int num2, int num3)
            {
                int min = 0;

                if (num1 < num2 && num1 < num3)
                    min = num1;
                if (num2 < num1 && num2 < num3)
                    min = num2;
                if (num3 < num1 && num3 < num2)
                    min = num3;

                return min;
            }

            Console.WriteLine("\n[결과 값]\n");
            Console.Write("Max:{0}  Min:{1}", CalMax(input[0], input[1], input[2]), CalMin(input[0], input[1], input[2]));
        }
        private static void Q13()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t13. 초를 입력후 [시간, 분, 초] 로 출력하는 메서드 제작");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Console.Write(" \"초\" 를 입력: ");

            int input = Int32.Parse(Console.ReadLine());
            int hours = 0, mins = 0, seconds = 0;
            Console.WriteLine("\n[결과 값]\n");

            seconds = input % 60;
            input /= 60;
            mins = input % 60;
            input /= 60;
            hours = input;

            Console.WriteLine($"[{hours}시 {mins}분 {seconds}초]");
        }
        static void Main(string[] args)
        {
            SelectQestion();
        }
    }
}
