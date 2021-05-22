using System;
using System.Collections.Generic;
using System.Text;

namespace _001_Homework_05_20
{
    class HomeWork2
    {
        static void Main(string[] args)
        {
            Console.Write("1.  for문을 이용해서 100부터 200까지 출력하세요 \n <문제 답>\n");
            for (int i = 100; i <= 200; i++)
                Console.Write(i + ", ");

            ClearQuestion();

            Console.Write("2. for문을 이용해서 10부터 20까지 5씩 증가하여 출력하세요 \n <문제 답>\n");
            for (int i = 10; i <= 20; i += 5)
                Console.Write(i + ", ");

            ClearQuestion();
            
            Console.Write("3. for문을 이용해서 1부터 10까지 합을 출력하세요 \n <문제 답>\n");
            int result = 0;
            for (int i = 1; i <= 10; i++)
                result += i;
                Console.Write("1에서 10까지의 합은 = " + result);

            ClearQuestion();

            Console.Write("4. for문을 이용해서 1부터 10까지 중에 짝수만 출력하세요 for문 내에 조건문을 넣어주면 됨 \n <문제 답>\n");
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }
            ClearQuestion();

            Console.Write("5. for문을 이용해서 10부터 0까지 2씩 감소하여 출력하세요 \n <문제 답>\n");
            for (int i = 10; i >= 0; --i)
            {
                if (i % 2 == 0)
                    Console.Write(i + ", ");
            }

                void ClearQuestion()
            {
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
