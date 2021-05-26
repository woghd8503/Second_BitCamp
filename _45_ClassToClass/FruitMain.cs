using System;
/*
    과일 판매자와 과일 구매자의 상호작용을 
    클래스로 프로그래밍
 */
namespace _45_ClassToClass
{
    class FruitMain
    {
        static void Main(string[] args)
        {
            FruitSeller seller0 = new FruitSeller("손오공", 0, 30, 1500);
            FruitSeller seller1 = new FruitSeller("저팔계", 0, 20, 2000);
            FruitBuyer buyer = new FruitBuyer("홍길동", 10000);

            buyer.buyApple(seller0, 3000);
            buyer.buyApple(seller1, 4000);

            buyer.showBuyResult();
            seller0.showSaleResult();
            seller1.showSaleResult();
        }
    }
}
