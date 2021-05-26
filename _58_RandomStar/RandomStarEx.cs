using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58_RandomStar
{
    class RandomStarEx
    {
        static void solveArray()
        {
            const int ARR_NUM = 100;
            Random rand = new Random();
            int[] arrLeft = new int[ARR_NUM];
            int[] arrTop = new int[ARR_NUM];
            for (int i = 0; i < ARR_NUM; i++)
            {
                int left = rand.Next(80);
                int top = rand.Next(24);
                arrLeft[i] = left;
                arrTop[i] = top;

                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("*");
                System.Threading.Thread.Sleep(100);
            }

            for (int i = ARR_NUM - 1; i >= 0; i--)
            {
                Console.CursorLeft = arrLeft[i];
                Console.CursorTop = arrTop[i];
                Console.Write(" ");
                System.Threading.Thread.Sleep(100);
            }
        }

        class StarPosition
        {
            public int left;
            public int top;
        }
        static void solveArray1()
        {
            Random rand = new Random();
            // StarPosition객체를 저장할 수 있는 100개짜리 참조변수 배열
            StarPosition[] arrStar = new StarPosition[100];
            for(int i = 0; i < arrStar.Length; i++)
            {
                int left = rand.Next(80);
                int top = rand.Next(24);
                arrStar[i] = new StarPosition();
                arrStar[i].left = left;
                arrStar[i].top = top;

                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("*");
                System.Threading.Thread.Sleep(100);
            }

            for(int i = arrStar.Length - 1; i >= 0; i--)
            {
                Console.CursorLeft = arrStar[i].left;
                Console.CursorTop = arrStar[i].top;
                Console.Write(" ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void solveArrayList()
        {
            Random rand = new Random();
            ArrayList arrList = new ArrayList();
            for (int i = 0; i < 100; i++)
            {
                int left = rand.Next(80);
                int top = rand.Next(24);
                StarPosition starPos = new StarPosition();
                starPos.left = left;
                starPos.top = top;
                arrList.Add(starPos);

                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("*");
                System.Threading.Thread.Sleep(100);
            }

            for (int i = arrList.Count-1; i >= 0; i--)
            {
                StarPosition starPos = (StarPosition)arrList[i];
                Console.CursorLeft = starPos.left;
                Console.CursorTop = starPos.top;
                Console.Write(" ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void solveStack()
        {
            Random rand = new Random();
            Stack arrStack = new Stack();
            for (int i = 0; i < 100; i++)
            {
                int left = rand.Next(80);
                int top = rand.Next(24);
                StarPosition starPos = new StarPosition();
                starPos.left = left;
                starPos.top = top;
                arrStack.Push(starPos);

                Console.CursorLeft = left;
                Console.CursorTop = top;
                Console.Write("*");
                System.Threading.Thread.Sleep(100);
            }

            for (int i = 0; i < 100; i++)
            {
                StarPosition starPos = (StarPosition)arrStack.Pop();
                Console.CursorLeft = starPos.left;
                Console.CursorTop = starPos.top;
                Console.Write(" ");
                System.Threading.Thread.Sleep(100);
            }
        }

        static void Main(string[] args)
        {
            /*
            100개 배열이나 ArrayList를 이용해서
            100개의 *을 80,24이내의 임의의 위치에
            0.1초 간격으로 1개씩 출력하고
            역순으로 1개씩 지우기를 반복하라
            */

            bool isRun = true;
            while (isRun)
            {
                Console.WriteLine("100개 배열이나 ArrayList를 이용해서"
                               + "\n100개의 * 을 80, 24이내의 임의의 위치에"
                               + "\n0.1초 간격으로 1개씩 출력하고"
                               + "\n역순으로 1개씩 지우기를 반복하라");
                Console.WriteLine();
                Console.WriteLine("1. 배열로 해결하기");
                Console.WriteLine("2. 배열로 해결하기1");
                Console.WriteLine("3. ArrayList로 해결하기");
                Console.WriteLine("4. Stack으로 해결하기");
                Console.WriteLine("5. 종료");
                Console.Write("번호 선택 >> ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.Clear();
                switch (sel)
                {
                    case 1:
                        solveArray();
                        break;
                    case 2:
                        solveArray1();
                        break;
                    case 3:
                        solveArrayList();
                        break;
                    case 4:
                        solveStack();
                        break;
                    case 5:
                        isRun = false;
                        break;
                    default:
                        Console.WriteLine("잘 못 입력했습니다");
                        break;
                }
                Console.Clear();
            }
        }
    }
}
