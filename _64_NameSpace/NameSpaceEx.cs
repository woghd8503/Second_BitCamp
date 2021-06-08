using System;

namespace A
{
    class Calc
    {
        public int add(int a, int b) { return a + b; }
        public int sub(int a, int b) { return a - b; }
        public int mul(int a, int b) { return a * b; }
        public int div(int a, int b) { return a / b; }
    }
}

namespace _62_namespace
{
    class NamespaceEx
    {
        static void Main(string[] args)
        {
            A.Calc calc = new A.Calc();
            Console.WriteLine(calc.add(10, 20));
            Console.WriteLine(calc.sub(10, 20));
            Console.WriteLine(calc.mul(10, 20));
            Console.WriteLine(calc.div(10, 20));
        }
    }
}