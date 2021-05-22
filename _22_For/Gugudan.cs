using System;

namespace _21_For
{
    class gugudan
    {
        static void Main(string[] args)
        {
                Gugudan1();
        }

        static void Gugudan1()
        {
            while (true)
            {
                Console.WriteLine("숫자를 입력하세요 <종료는 입력 : 0 >");
                int num = Int32.Parse(Console.ReadLine());
                if (num == 0)
                    break;

                for (int i = 1; i <= 9; i++)
                {
                    Console.WriteLine("{0}X{1}={2}", num, i, num * i);
                }
                ClearScreen();
            }
        }
        static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
    }
}
