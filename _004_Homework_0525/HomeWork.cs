using System;

namespace _004_Homework_0525
{
//1. 나는 마트에 가서 5000원을 주고 배 가격 2500를 샀다를
//   클래스로 설계해서 프로그래밍 하세요
   
//2. "나는 연필판매자로부터 3000원을 내고 연필 2자루를 구매했다"
//   를 객체 상호작용으로 프로그래밍 하세요


    class PairBuyer
    {
        int money = 5000;
        int pairCount = 0;

        public void GoToMarket()
        {
            Console.WriteLine("1. 나는 배를 사기 위해 마트로 간다.\n");
        }

        public int PayPairPrice()
        {
            Console.WriteLine($"2. 나는 배 1개(2,500값)을 구매하기 위해 {money}원을 지불한다.\n");

            return money;
        }

        public void BuyApair(int _change, int _pairCount)
        {
            money = _change;
            pairCount = _pairCount;

            Console.WriteLine($"3. 나는 잔돈으로 {money}원 을 받고 배 {pairCount}를 받았다.\n");
        }
    }

    class PencilBuyer
    {
        int money = 3000;
        int pencilCount = 0;
        
        public int PayForPencil()
        {
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"[구매자] 나는 연필을 사기위해 판매자에게 {money}을 지불했다.\n");
            return money;
        }

        public void BuyPencial(int _pencilCount)
        {
            System.Threading.Thread.Sleep(500);
            pencilCount = _pencilCount;
            Console.WriteLine($"[구매자] 연필 판매자에서 연필{_pencilCount}자루를 받았다. 나는 연필{pencilCount}자루를 소지하고 있다.\n");
        }
    }
    class PencilSeller
    {
        int pencialCount = 0;
        int pencialPrice = 1500;

        public int SellPencil(int _money)
        {
            System.Threading.Thread.Sleep(500);
            for (int i = 0; i < 100; i++)
            {
                if((i*1500) == _money)
                {
                    pencialCount = i;
                    break;
                }
            }
            Console.WriteLine($"[판매자] 손님에게 {_money}원을 받고 연필 {pencialCount}자루를 손님에게 드렸다.\n");
            return pencialCount;
        }
    }

    class HomeWork
    {
        static void Q1()
        {
            int change = 2500;
            int pairCount = 1;

            PairBuyer buy = new PairBuyer();
            buy.GoToMarket();
            System.Threading.Thread.Sleep(800);
            buy.PayPairPrice();
            System.Threading.Thread.Sleep(800);
            buy.BuyApair(change, pairCount);
        }
        static void Q2()
        {
            PencilBuyer pBuyer = new PencilBuyer();
            PencilSeller pSeller = new PencilSeller();

            pBuyer.BuyPencial(pSeller.SellPencil(pBuyer.PayForPencil()));
        }
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }
    }
}
