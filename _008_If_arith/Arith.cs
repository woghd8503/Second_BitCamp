using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_If_arith
{
    class Arith
    {
        static void Main(String[] args)
        {
            int num0 = 0, num1 = 0, result = 0;
            string op;

            Console.WriteLine("사칙연산을 합니다.");
            Console.WriteLine("첫번재 숫자 입력 : ");
            string strNum0 = Console.ReadLine();
            num0 = Int32.Parse(strNum0);

            Console.WriteLine("두번째 숫자 입력 : ");
            string strNum1 = Console.ReadLine();
            num1 = Int32.Parse(strNum1);

            Console.WriteLine("+ - * / % 연산자 입력: ");
            op = Console.ReadLine();

            if (op == "+")
                result = num0 + num1;
            else if (op == "-")
                result = num0 - num1;
            else if (op == "*")
                result = num0 * num1;
            else if (op == "/")
                result = num0 / num1;
            else if (op == "%")
                result = num0 % num1;
            Console.WriteLine("결과값은 " + result + "입니다.");
        }
    }
}
