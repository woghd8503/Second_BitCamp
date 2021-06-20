using System;

namespace _28_MoveShap
{
    class MoveShap
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int x1 = 79;
            int y1 = 20;

            bool xDirection = true;
            bool yDirection = true;

            while (true)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("#");
                System.Threading.Thread.Sleep(30);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");

                if (xDirection == true)    // 방향설정
                    x++;
                if (xDirection == false)   // 방향설정
                    x--;
                if (yDirection == true)   // 방향설정
                    y++;
                if (yDirection == false)  // 방향설정
                    y--;

                if (x == x1)
                    xDirection = false;
                if (y == y1)
                    yDirection = false;

                if (x == 1)
                    xDirection = true;
                if (y == 1)
                    yDirection = true;


            }
        }
    }
}

