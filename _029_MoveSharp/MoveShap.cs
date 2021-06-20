using System;

namespace _28_MoveShap
{
    class MoveShap
    {
        static void Main(string[] args)
        {
            int x = 0, y = 12;

            while (x <= 80)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("#");
                System.Threading.Thread.Sleep(100);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");
                x++;
            }
        }
    }
}
