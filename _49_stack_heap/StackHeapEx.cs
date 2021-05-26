using System;

namespace _49_stack_heap
{
    class Human
    {
        public int age;
        public string name;
    }
    class StackHeapEx
    {
        static void Main(string[] args)
        {
            int num = 10;
            System.Int32 num1 = 100;
            char ch = 'A';
            double dNum = 3.14;

            Human hu = new Human();
            hu.age = 24;
            hu.name = "홍길동";
            Console.WriteLine(hu.GetHashCode());

            string str = "korea";
            int[] arr = { 1, 2, 3, 4, 5 };
        }
    }
}
