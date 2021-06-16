using System;
using System.Collections.Generic;

namespace _126_GenericList
{
    class GenericListEx
    {
        static void Main(string[] args)
        {
            //링크드리스트 자료구조를 Generic으로 만든
            //닷넷 (컬렉션) 클래스
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int elem in list)
                Console.WriteLine(elem + " ");
            Console.WriteLine();

            list.RemoveAt(2); // index 2 요소 제거

            foreach (int elem in list)
                Console.Write(elem + " ");
            Console.WriteLine();
        }
    }
}
