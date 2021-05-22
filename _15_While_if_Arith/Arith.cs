using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_switch_case
{
    class Arith
    {
        static void Main(String[] args)
        {
            int num0 = 0, num1 = 0, result = 0;
            string op;

            bool isRun = true;
            // 무한 루프 (계속 반복)
            while(isRun)
            {
                Console.WriteLine("사칙연산을 합니다.");
                Console.Write("첫번재 숫자 입력 : ");
                string strNum0 = Console.ReadLine();
                num0 = Int32.Parse(strNum0);

                Console.Write("두번째 숫자 입력 : ");
                string strNum1 = Console.ReadLine();
                num1 = Int32.Parse(strNum1);

                Console.WriteLine("+ - * / % 연산자 입력(exit는 종료): ");
                op = Console.ReadLine();

                switch (op)
                {
                    case "+":
                        result = num0 + num1;
                        break;
                    case "-":
                        result = num0 - num1;
                        break;
                    case "*":
                        result = num0 * num1;
                        break;
                    case "/":
                        result = num0 / num1;
                        break;
                    case "%":
                        result = num0 % num1;
                        break;
                    case "exit":
                        isRun = false;
                        Console.WriteLine("탈출");
                        break;
                    default:
                        Console.WriteLine("알맞은 연산자가 없습니다.");
                        break;
                }
                if(isRun) // if(isRun == true)
                Console.WriteLine("결과값은 " + result + "입니다.");

                    // 아무키나 누르도록 대기상태 다만 입력값은 저장하지 않도록 함
                    Console.ReadLine();
                    Console.Clear();
            }
        }
    }
}
