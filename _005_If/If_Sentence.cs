using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_If
{
    class If_Sentence
    {
        static void Main(string[] args)
        {
            int num = 0;

            Console.Write("숫자 입력: ");
            string strNum = Console.ReadLine();
            num = Int32.Parse(strNum);
            if(num == 100)
            {
                Console.WriteLine("num은 100입니다.");
            }
        }
    }
}
