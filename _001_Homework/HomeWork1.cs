using System;
using System.Collections.Generic;
using System.Text;

namespace _20_Character
{
    class HomeWork1
    {
        static void Main(string[] args)
        {
            Console.Write("1. do~while문을 이용해서 100부터 200까지 출력하세요 \n <문제 답>\n");
            int num = 100;
            do
            {
                Console.Write(num + ", ");
                num++;
            } while (num <= 200);

            Console.ReadLine();
            Console.Clear();

            Console.Write("2. do~while문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요 \n <문제 답>\n");
            num = 10;
            do
            {
                if (num % 5 == 0)
                    Console.Write(num + ", ");
                num++;
            } while (num <= 20);

            Console.ReadLine();
            Console.Clear();

            Console.Write("3. do~while문을 이용해서 1부터 10까지 합을 출력하세요 \n <문제 답>\n");
            num = 1;
            int result = 0;
            do
            {
                result += num;
                num++;
            } while (num <= 10);
            Console.Write("1에서 10까지 합은 = " + result);

            Console.ReadLine();
            Console.Clear();

            Console.Write("4. do~while문을 이용해서 1부터 10까지 중에 짝수만 출력하세요 do ~while문내에 조건문을 넣어주면 됨 짝수 조건 if (num % 2 == 0) \n <문제 답>\n");
            num = 1;
            do
            {
                if (num % 2 == 0)
                    Console.Write(num + ", ");
                num++;
            } while (num <= 10);

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("5. do~while문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요");
            num = 10;
            do
            {
                if (num % 2 == 0)
                    Console.Write(num + ", ");
                num--;
            } while (num >= 0);
        }
    }
}
