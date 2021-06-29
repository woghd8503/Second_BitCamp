using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _91_delegate
{
    class DelegateEx
    {
        public static int add(int a, int b) { return a + b; }
        public static int sub(int a, int b) { return a - b; }
        public static int mul(int a, int b) { return a * b; }
        public static int div(int a, int b) { return a / b; }
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            int op = 0;
            Console.Write("Input Num1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input Num2: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Input Number (1:+, 2:-, 3:*, 4:/) ");
            op = Int32.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("result = " + add(num1, num2));
                    break;
                case 2:
                    Console.WriteLine("result = " + sub(num1, num2));
                    break;
                case 3:
                    Console.WriteLine("result = " + mul(num1, num2));
                    break;
                case 4:
                    Console.WriteLine("result = " + div(num1, num2));
                    break;
            }
        }
    }
}
