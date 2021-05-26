using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51_ArrayList
{
    class ArrayListEx
    {
        static void Main(string[] args)
        {
            /*배열과 용도는 동일하지만
            자료형에 구애를 받지 않는다
            삽입이나 삭제도 편리하다.*/
            ArrayList arList = new ArrayList();
            arList.Add(1);
            arList.Add(3.14);
            arList.Add("홍길동");
            arList.Add(new DateTime(2021, 5, 25));

            for (int i = 0; i < arList.Count; i++)
            {
                Object obj = arList[i];
                Console.WriteLine(obj);
            }

            Console.WriteLine("==================");

            arList.Insert(1, 12345678);

            foreach (Object obj in arList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
