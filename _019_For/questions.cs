using System;

namespace _19_For
{
    class questions
    {
        static void Main(string[] args)
        {
            //1. 1 ~ 100까지 출력하세요
            for(int i = 1; i <=100 ; ++i )
            {
                //Console.Write("{0}, ", i);
                Console.Write(i + ", ");
            }

            Console.ReadLine();
            Console.Clear();

            //2. 10 ~ 100까지 출력하세요
            for(int i = 10; i <= 100; i +=2)
                Console.Write(i + ", ");

            Console.ReadLine();
            Console.Clear();

            //3. 1 ~ 100까지 더해서 결과값 출력(for문으로)
            int result = 0;
            for(int i = 1; i <= 100; ++i)
                result += i;
            Console.WriteLine("1~100의 합은: {0}", result);
        }
    }
}
