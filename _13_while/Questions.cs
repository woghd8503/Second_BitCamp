using System;

namespace _13_while
{
    class Questions
    {
        static void Main(string[] args)
        {
            //1. 1 ~ 100까지 출력하세요
            int num = 0, num1 = 10, num2 = 0, result = 0;
            while (num <= 100)
            {
                Console.Write(num++ + ", ");
            }

            Console.ReadLine();
            Console.Clear(); // 화면 청소

            //2. 10 ~ 100까지 2씩 증가시켜 출력
            while (num1 <= 100)
            {
                Console.Write(num1 + ", ");
                num1 = num1 + 2;
            }

            Console.ReadLine();
            Console.Clear();

            //3. 1 ~ 100까지 더해서 결과값 출력
            while (num2 <= 100)
            {
                // result = result + num2;
                result += num2;
                ++num2;
            }
            Console.WriteLine("1~100까지 누적합 = " + result);
        }
    }
}
