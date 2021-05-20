using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Operator
{
    class Operator
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0;
            int result = 0;

            Console.WriteLine("더하기 연산을 합니다.");
            Console.Write("첫번재 숫자 입력: ");
            string strNum0 = Console.ReadLine(); // 입력
            num0 = Int32.Parse(strNum0);         // 문자열 -> 숫자

            Console.Write("두번재 숫자 입력: ");
            string strNum1 = Console.ReadLine(); // 입력
            num1 = Int32.Parse(strNum1);         // 문자열 -> 숫자

            result = num0 + num1;
            Console.WriteLine("결과값은 " + result + "입니다");
        }
    }
}
