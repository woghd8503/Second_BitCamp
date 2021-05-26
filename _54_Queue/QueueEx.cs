using System;
using System.Collections;

namespace _54_Queue
{
    class QueueEx
    {
        static void Main(string[] args)
        {
            Queue qu = new Queue();
            qu.Enqueue(10);
            qu.Enqueue(20);
            qu.Enqueue(30);

            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
            Console.WriteLine(qu.Dequeue());
        }
    }
}
