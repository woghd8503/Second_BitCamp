using System;

namespace _28_MoveShap
{
    class MoveShap
    {
        static void Main(string[] args)
        {
            int x = 0, y = 12, x1 = 0, y1 = 0;
            
             1. #이 끝에 닿으면 다시 처음부터 등장
                        while (x <= 80)
                        {
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.Write("#");
                            System.Threading.Thread.Sleep(10);
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.Write(" ");
                            x++;
                            if (x == 80)
                                x = 0;
                        }

             2. #이 왕복하도록 할 것
                        while (x <= 80)
                        {
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.Write("#");
                            System.Threading.Thread.Sleep(10);
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.Write(" ");
                            x++;
                            if (x == 80)
                            {
                                while (x >= 1)
                                {
                                    x--;
                                    Console.CursorLeft = x;
                                    Console.CursorTop = y;
                                    Console.Write("#");
                                    System.Threading.Thread.Sleep(10);
                                    Console.CursorLeft = x;
                                    Console.CursorTop = y;
                                    Console.Write(" ");
                                }
                            }
                        }*/

            // 3. #이 2개로 가로왕복/세로왕복

            MoveSharpY();

            // 4. #이 반사되도록 

        }
        static void MoveSharpY()
        {
            int x1 = 10, y1 = 0;
            while (y1 <= 30)
            {
                Console.CursorLeft = x1;
                Console.CursorTop = y1;
                Console.Write("#");
                System.Threading.Thread.Sleep(10);
                Console.CursorLeft = x1;
                Console.CursorTop = y1;
                Console.Write(" ");
                y1++;
                if (y1 == 30)
                    while (y1 >= 1)
                    {
                        y1--;
                        Console.CursorLeft = x1;
                        Console.CursorTop = y1;
                        Console.Write("#");
                        System.Threading.Thread.Sleep(10);
                        Console.CursorLeft = x1;
                        Console.CursorTop = y1;
                        Console.Write(" ");
                    }
            }
        }
        static void MoveSharpX()
        {
            int x = 0, y = 12;
            while (x <= 80)
            {
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write("#");
                System.Threading.Thread.Sleep(20);
                Console.CursorLeft = x;
                Console.CursorTop = y;
                Console.Write(" ");
                x++;
                if (x == 80)
                {
                    while (x >= 1)
                    {
                        x--;
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write("#");
                        System.Threading.Thread.Sleep(20);
                        Console.CursorLeft = x;
                        Console.CursorTop = y;
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}
