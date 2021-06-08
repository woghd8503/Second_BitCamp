using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Homework_05._21
{
/*1. #이 끝에 닿으면 다시 처음부터 등장
2. #이 왕복하도록 할 것
3. #이 2개로 가로왕복/세로왕복
4. #이 반사되도록*/
    class HomeWork4
    {
        static void Main(string[] args)
        {
            double count = 0;
            int x = 0, y = 10;
            int x1 = 0, y1 = 10;
            int x2 = 0, y2 = 10;
            int xdirection = 1;
            int ydirection = 0;
            int xWall = 67;
            int yWall = 19;

            bool xDir = true;
            bool yDir = true;

            bool xDir1 = true;
            bool yDir1 = true;
            /*
                        while (true)
                        {
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.WriteLine("#");
                            System.Threading.Thread.Sleep(10);
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.WriteLine(" ");
                            x++;
                        }*/

            /*            while (true)
                        {
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.WriteLine("#");
                            System.Threading.Thread.Sleep(10);
                            Console.CursorLeft = x;
                            Console.CursorTop = y;
                            Console.WriteLine(" ");
                            x++;

                            if (x == 70)
                            {
                                x = 0;
                            }*/

            while (true)
            {
                count++;
/*                if(count % 1 == 0)
                {
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.WriteLine("#");
                    System.Threading.Thread.Sleep(10);
                    Console.CursorLeft = x;
                    Console.CursorTop = y;
                    Console.WriteLine(" ");
                    if (x == 78)
                        xDir = false;

                    if(x == 1)
                        xDir = true;

                    if (xDir == true)
                        x++;
                    if (xDir == false)
                        x--;
                }

                if (count % 2 == 0)
                {
                    Console.CursorLeft = x1;
                    Console.CursorTop = y1;
                    Console.WriteLine("$");
                    System.Threading.Thread.Sleep(10);
                    Console.CursorLeft = x1;
                    Console.CursorTop = y1;
                    Console.WriteLine(" ");

                    if (y1 == 15)
                        yDir = false;

                    if (y1 == 2)
                        yDir = true;

                    if (yDir == true)
                        y1++;
                    if (yDir == false)
                        y1--;
                }
*/
                if (count % 3 == 0)
                {
                    Console.CursorLeft = x2;
                    Console.CursorTop = y2;
                    Console.WriteLine("*");
                    System.Threading.Thread.Sleep(50);
                    Console.CursorLeft = x2;
                    Console.CursorTop = y2;
                    Console.WriteLine(" ");

                    if (x2 == xWall)
                        xDir1 = false;

                    if (x2 == 2)
                        xDir1 = true;

                    if (y2 == yWall)
                        yDir1 = false;

                    if (y2 == 2)
                        yDir1 = true;


                    if (yDir1 == true)
                        y2++;
                    if (yDir1 == false)
                        y2--;

                    if (xDir1 == true)
                        x2++;
                    if (xDir1 == false)
                        x2--;
                }
            }
        }
    }
}

