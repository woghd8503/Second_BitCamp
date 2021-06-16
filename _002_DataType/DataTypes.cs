using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_DataType
{
    /*    
    변수 : 값을 저장하는 이름붙인 공간
    자료형(DataType) : 변수를 만들때 사용하는 약속 기호
    */
    class DataTypes
    {
        static void Main(string[] args)
        {
            /* 정식화된 이름
            System.Int32 num0 = 100;
            System.Double dnum0 = 3.141592;
            System.Char ch0 = '0';
            System.String name0 = "홍길동";*/

            // 관습-많이 쓴 자료형
            int num = 100;          // 정수
            double dnum = 3.14;     // 실수(소수점)
            char ch = 'a';          // 문자
            string name = "albert"; // 문자열
            Console.WriteLine("{0},{1},{2},{3},", num, dnum, ch, name);
        }
    }
}
