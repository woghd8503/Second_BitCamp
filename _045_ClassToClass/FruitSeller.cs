using System;
using System.Collections.Generic;
using System.Text;

namespace _45_ClassToClass
{
    class FruitSeller
    {
        string name;
        int numOfApple; // 과일 개수
        int myMoney;    // 보유한 돈
        // readonly는 생성자에서 1번만 값을 변경 가능
        readonly int APPLE_PRICE; // 사과 가격

        public FruitSeller(string name, int money, int appleNum, int price)
        {
            // 필드와 생성자 안에 동일한 이름이 있을 때 this를 사용.
            this.name = name;
            this.numOfApple = appleNum;
            this.myMoney = money;
            APPLE_PRICE = price;
        }
        public int saleApple(int money)
        {
            int num = money / APPLE_PRICE;
            this.numOfApple -= num;
            this.myMoney += money;
            return num;
        }
        public void showSaleResult()
        {
            Console.WriteLine("=======판매자 : {0}=======", this.name);
            Console.WriteLine("남은 사과: " + this.numOfApple);
            Console.WriteLine("판매 수익: " + this.myMoney);
        }
    }
}
