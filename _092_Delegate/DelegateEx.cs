using System;
using System.Collections.Generic;
using System.Text;

namespace _91_Deligate
{
    //intCalc라는 새로운 타입을 정의하겠다.
    //이 타입은 delegate키워드가 있으므로
    //이 타입의 변수는 메서드를 저장할 수 있다.
    //그리고 해당 메서드는
    //int 리턴형에 매개변수가 int, int로 되어져 있어야 한다..
    delegate int intCalc(int a, int b);
    class DelegateEx
    {
        public static int add(int a, int b) { return a + b; }
        public static int sub(int a, int b) { return a - b; }
        public static int mul(int a, int b) { return a * b; }
        public static int div(int a, int b) { return a / b; }
        static void Main(string[] args)
        {
            intCalc[] calcArr = { add, sub, mul, div };
            int num1 = 0, num2 = 0;
            int op = 0;
            Console.Write("Input Num1: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Input Num2: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Input Number (1: +, 2: -, 3: *, 4: /) ");
            op = Int32.Parse(Console.ReadLine());
            Console.WriteLine("result = " + calcArr[op - 1](num1, num2));
        }
    }
}
