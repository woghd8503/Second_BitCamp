using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Homework_05_20
{
    class HomeWork
    {
        //1. while문을 이용해서 100부터 200까지 출력하세요
        //2. while문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요
        //3. while문을 이용해서 1부터 10까지 합을 출력하세요
        //4. while문을 이용해서 1부터 10까지 중에 짝수만 출력하세요
        //   while문내에 조건문을 넣어주면 됨
        //   짝수 조건 if(num % 2 == 0)
        //5. while문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요
        static void Main(string[] args)
        {
            Console.Write("1. while문을 이용해서 100부터 200까지 출력하세요 \n <문제 답>\n");
            int num = 100;
            while (num <= 200)
            {
                Console.Write(num + ", ");
                num++;
            }

            Console.ReadLine();
            Console.Clear();

            Console.Write("2. while문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요 \n <문제 답>\n");
            num = 10;
            while (num <= 20)
            {
                Console.Write(num + ", ");
                num += 5;
            }

            Console.ReadLine();
            Console.Clear();

            Console.Write("3. while문을 이용해서 1부터 10까지 합을 출력하세요 \n <문제 답>\n");
            num = 0;
            int result = 0;
            while (num <= 10)
            {
                result += num;
                ++num;
            }
            Console.Write(result);

            Console.ReadLine();
            Console.Clear();

            Console.Write("4. while문을 이용해서 1부터 10까지 중에 짝수만 출력하세요 while문내에 조건문을 넣어주면 됨 짝수 조건 if(num % 2 == 0) \n <문제 답>\n");
            num = 0;
            while (num <= 10)
            {
                num++;
                if (num % 2 == 0)
                    Console.Write(num + ", ");
            }

            Console.ReadLine();
            Console.Clear();

            Console.Write("5. while문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요 \n <문제 답>\n");
            num = 10;
            while(num > 0)
            {
                
                if (num % 2 == 0)
                    Console.Write(num + ", ");
                num--;
            }
            Console.Write("\n");
        }
    }
}
