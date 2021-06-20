using System;
using System.Collections;

namespace _53_Stack
{
    class StackEx
    {
        static void Main(string[] args)
        {
            // 들어간 순서의 반대로 꺼내지는 자료구조
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);

            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
            Console.WriteLine(st.Pop());
        }
    }
}
