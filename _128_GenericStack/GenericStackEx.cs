using System;
using System.Collections.Generic;

namespace _128_GenericStack
{
    class GenericStackEx
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("대한민국");
            stack.Push("대한제국");
            stack.Push("조선");
            stack.Push("고려");
            stack.Push("신라");
            stack.Push("발해");
            stack.Push("백제");
            stack.Push("고구려");
            stack.Push("부여");
            stack.Push("동예");
            stack.Push("옥저");
            stack.Push("고조선");

            while (stack.Count > 0)
                Console.Write(stack.Pop() + " ");
            Console.WriteLine();

        }
    }
}
