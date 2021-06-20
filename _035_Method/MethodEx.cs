using System;

namespace _35_Method
{
    class MethodEx
    {
        static int totalSum(int from, int to)
        {
            int total = 0;
            for (int i = from; i <= to; i++)
                total += i;
            return total;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1 ~ 100의 합계 =" +
                totalSum(1, 100));
            Console.WriteLine("1 ~ 100의 합계 =" +
                totalSum(1, 1000));
            Console.WriteLine("1 ~ 100의 합계 =" +
                totalSum(1, 10000));
        }
    }
}
