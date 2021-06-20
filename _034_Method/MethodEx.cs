using System;

namespace _34_Method
{
    class MethodEx
    {
        static int add(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            int result = add(10, 20);
            Console.WriteLine("result=" + result);
            result = add(100, 200);
            Console.WriteLine("result=" + result);
        }
    }
}
