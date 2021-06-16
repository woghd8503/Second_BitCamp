using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*연산자
크게 2가지의 분류
1) 산술연산자(+ - * / %)
2) 비교연산자(> < == >= <=)*/
namespace _04_Operator
{
    class Operator
    {
        static void Main(string[] args)
        {
            int num0 = 0, num1 = 0;
            bool bResult; // True / False

            Console.WriteLine("비교 연산을 합니다.");
            Console.Write("첫번재 숫자 입력: ");
            string strNum0 = Console.ReadLine(); // 입력
            num0 = Int32.Parse(strNum0);         // 문자열 -> 숫자

            Console.Write("두번재 숫자 입력: ");
            string strNum1 = Console.ReadLine(); // 입력
            num1 = Int32.Parse(strNum1);         // 문자열 -> 숫자

            bResult = num0 > num1;
            Console.WriteLine("{0}은 {1}보다 크다는 사실은 {2}", num0, num1, bResult);
        }
    }
}
