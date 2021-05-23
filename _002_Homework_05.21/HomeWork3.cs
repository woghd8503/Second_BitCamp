using System;
using System.Collections.Generic;
using System.Text;

namespace _002_Homework_05_21
{
    class HomWork3
    {
        //1. #이 끝에 닿으면 다시 처음부터 등장
        //2. #이 왕복하도록 할 것
        //3. #이 2개로 가로왕복/세로왕복
        //4. #이 반사되도록
        static void Main(string[] args)
        {
            SelectQestion();
        }

        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 <나가기는 10 입력>: ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 10)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    case 4:
                        Q4();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }

        private static void Q1()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. #이 끝에 닿으면 다시 처음부터 등장");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int x = 0, y = 12;

            while (x <= 80)
            {
                MoveSharp(x, y);
                x++;
                if (x == 80)
                    x = 0;
            }
        }

        private static void Q2()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t2. #이 왕복하도록 할 것");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int x = 0, y = 12;

            while (x <= 80)
            {
                MoveSharp(x, y);
                x++;
                if (x == 80)
                {
                    while (x >= 1)
                    {
                        x--;
                        MoveSharp(x, y);
                    }
                }
            }
        }

        private static void Q3()
        {
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. #이 2개로 가로왕복/세로왕복");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int x = 0, y = 12;
            int x1 = 12, y1 = 4;
            int xWall = 80, yWall = 25;
            int xSpeed = 4, y1Speed = 1;

            while (x <= xWall || y1 <= yWall)
            {
                MoveSharp(x, y);
                MoveSharp(x1, y1);
                x += xSpeed;
                y1 += y1Speed;
                if (x == xWall || y1 == yWall)
                {
                    while (x >= 1 || y1 >= 5)
                    {
                        x -= xSpeed;
                        y1 -= y1Speed;
                        MoveSharp(x, y);
                        MoveSharp(x1, y1);
                    }
                }
            }
        }

        private static void Q4()
        {
            int x = 0, y = 4;
            int xWall = 79, yWall = 24;
            bool xDirection = true;
            bool yDirection = true;

            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. #이 반사되도록");
            Console.WriteLine("--------------------------------------------------------------------------------");

            while (true)
            {
                MoveSharp(x, y, 100);
                
                if(x == xWall)
                    xDirection = false;
                if(x == 0)
                    xDirection = true;
                if (xDirection == true)
                    x++;
                else if (xDirection == false)
                    x--;
                if(y == yWall)
                    yDirection = false;
                if(y == 4)
                    yDirection = true;
                if(yDirection == true)
                    y++;
                if(yDirection == false)
                    y--;
            }
        }

        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }

        private static void MoveSharp(int x, int y, int s = 10)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write("#");
            System.Threading.Thread.Sleep(s);
            Console.CursorLeft = x;
            Console.CursorTop = y;
            Console.Write(" ");
        }
    }
}
