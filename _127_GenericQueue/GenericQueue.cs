using System;
using System.Collections.Generic;
using System.Text;

namespace _127_GenericQueue
{
    class GenericQueue
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("대한민국");
            queue.Enqueue("대한제국");
            queue.Enqueue("조선");
            queue.Enqueue("고려");
            queue.Enqueue("신라");
            queue.Enqueue("발해");
            queue.Enqueue("백제");
            queue.Enqueue("고구려");
            queue.Enqueue("부여");
            queue.Enqueue("동예");
            queue.Enqueue("옥저");
            queue.Enqueue("고조선");

            // 하나씩 꺼낸다(Dequeue)
            while (queue.Count > 0)
                Console.Write(queue.Dequeue() + " ");
            Console.WriteLine();
        }
    }
}
