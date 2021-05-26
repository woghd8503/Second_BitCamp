using System;
using System.Collections;

namespace _52_HashTable
{
    class HashTableEx
    {
        static void Main(string[] args)
        {
            //key, value로 저장되는 자료구조(컬렉션)
            //key로 검색하면 value를 얻을 수 있다.
            Hashtable ht = new Hashtable();
            ht.Add("boy", "소년");
            ht.Add("girl", "소녀");
            ht.Add("school", "학교");
            Console.WriteLine(ht["boy"]);
            Console.WriteLine(ht["girl"]);
            Console.WriteLine(ht["school"]);

            ht["의적"] = "홍길동";
            Console.WriteLine(ht["의적"]);
        }
    }
}
