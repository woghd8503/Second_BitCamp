using System;
//자식한테 물려주는 재정의(overriding)가능하게 하는
//메서드는 선언할 때 virtual 키워드를 써준다.
//그리고 자식은 재정의 시 override 키워드를 써준다. 

//  객체지향
//    부모 - 자식
//    Parent - child
//    Base - Derived
namespace _76_Overriding
{
    class GrandFather
    {
        public int money = 1000000000;

        public virtual void wealth()
        {
            Console.WriteLine("현금{0}을 가졌다", money);
        }
    }
    class Father : GrandFather
    {
        public int score = 99;
        public virtual void Study()
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
        // 물려받은 부모 메서드의 기능에
        // 덧붙인다
        public override void wealth()
        {
            base.wealth(); // 물려받은 wealth()를 호출
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
