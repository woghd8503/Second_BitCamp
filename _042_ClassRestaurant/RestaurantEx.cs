using System;

namespace _42_ClassRestaurant
{
    class Restaurant
    {
        // 필드는 기본권한을 private
        private string[] foods = { "냉명", "칼국수", "쌀국수", "떡볶이", "순대", "튀김" };
        private string selFood = "";
        private int select = 0;

        // 메서드는 기본권한을 public
        public void QuestionOrder()
        {
            for (int i = 0; i < foods.Length; i++)
            {
                Console.WriteLine("{0}. {1}", i + 1, foods[i]);
            }
        }
        public void SelectFood() {
            Console.Write("어느 음식을 선택하실래요 ? ");
            select = Int32.Parse(Console.ReadLine());
            selFood = foods[select];
        }
        public void DeliveryFood() {
            Console.WriteLine("{0}이 나왔습니다", selFood);
            Console.WriteLine("맛있게 드세요 ^^");
        }
    }
    class RestaurantEx
    {
        static void Main(string[] args)
        {
            Restaurant rest = new Restaurant();
                rest.QuestionOrder();
                rest.SelectFood();
                rest.DeliveryFood();
        }
    }
}
