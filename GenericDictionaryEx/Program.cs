using System;
using System.Collections.Generic;

namespace _129_GenericDictionaryEx
{
    class Program
    {
        static void Main(string[] args)
        {
            //딕셔너리, 맵, 해시 구조 모두 동일한 자료구조
            //검색이 매우 빠른 자료구조
            // key값이 중복될 수 없음


            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["하나"] = "one";
            dic["둘"] = "two";
            dic["셋"] = "three";
            dic["넷"] = "four";
            dic["다섯"] = "five";

            Console.WriteLine(dic["하나"]);
            Console.WriteLine(dic["둘"]);
            Console.WriteLine(dic["셋"]);
            Console.WriteLine(dic["넷"]);
            Console.WriteLine(dic["다섯"]);
        }
    }
}
