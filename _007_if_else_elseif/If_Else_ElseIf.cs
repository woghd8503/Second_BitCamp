using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_If_else_elseif
{
    class If_Else
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("숫자 입력: ");
            string strNum = Console.ReadLine();
            num = Int32.Parse(strNum);
            if (num > 100)
            {
                Console.WriteLine("num은 100보다 큽니다");
            }
            else if(num < 100)
            {
                Console.WriteLine("num은 100보다 작습니다.");
            }
            else
            {
                Console.WriteLine("num은 100이 아닙니다.");
            }
        }
    }
}

