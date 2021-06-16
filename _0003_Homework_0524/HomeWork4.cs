using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Homework_0524
{
    //1. 중화요리집을 임의대로 클래스로 자유롭게 만드세요

    //2. 학생이 아침에 일어나서 준비하고
    //   공부하다 가는 일과를 클래스로 자유롭게 만드세요.
    class Restaurnat
    {
        string[] menu = new string[6] { "짜장면", "짬뽕", "탕수육", "유산슬", "울면", "Exit" };
        string selFood = "";
        int sel = 0;

        public void ShowMenu()
        {
            Console.WriteLine("=======================");
            Console.WriteLine("원하시는 메뉴를 고르시오.");
            Console.WriteLine("=======================");
            for (int i = 0; i < menu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {menu[i]}");
            }
        }
        public string SelMenu()
        {
            sel = Int32.Parse(Console.ReadLine());
            selFood = menu[sel -1];
            return selFood;
        }

        public void deliveryFood()
        {
            Console.WriteLine($"선택하신 음식은 [{selFood}] 입니다.");
        }
    }
    class DailyStudying
    {

    }


    class HomeWork4
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void SelectQestion()
        {
            Restaurnat rest = new Restaurnat();
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 0)
                    break;
                switch (sel)
                {
                    case 1:
                        while (true)
                        {
                            ClearScreen();
                            rest.ShowMenu();
                            if (rest.SelMenu() == "Exit")
                                break;
                            rest.deliveryFood();
                        }
                        break;
                    case 2:
                        
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }
        static void Main(string[] args)
        {
            SelectQestion();
        }
    }
}

