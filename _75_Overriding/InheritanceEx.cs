using System;

namespace _75_Overriding
{
    class GrandFather
    {
        public int money = 1000000000;

        public void wealth()
        {
            Console.WriteLine("현금{0}을 가졌다", money);
        }
    }
    class Father : GrandFather
    {
        public int score = 99;
        public void Study()
        {
            Console.WriteLine("IT 점수 {0}", score);
        }
    }
    class Child : Father
    {
        // 새롭게 추가
        public string office = "부산시장";
        public void run()
        {
            Console.WriteLine(office + "역할을 잘 수행했다");
        }
        public int weight = 1000;
        // 상속받은 메서드를 무시하고
        // 새롭게 정의한다
        public new void wealth()
        {
            Console.WriteLine("금괴{0}을 가졌다", weight);
        }
    }
    class InheritanceEx
    {
        static void Main(string[] args)
        {
            GrandFather grandFather = new GrandFather();
            Console.WriteLine("---{0}---", grandFather);
            Console.WriteLine(grandFather.money);
            grandFather.wealth();

            Father father = new Father();
            Console.WriteLine("---{0}---", father);
            Console.WriteLine(father.money);
            father.wealth();
            Console.WriteLine(father.score);
            father.Study();

            Child child = new Child();
            Console.WriteLine("---{0}---", child);
            Console.WriteLine(child.money);
            Console.WriteLine(child.weight);
            child.wealth();
            Console.WriteLine(child.score);
            child.Study();
            Console.WriteLine(child.office);
            child.run();
        }
    }
}
