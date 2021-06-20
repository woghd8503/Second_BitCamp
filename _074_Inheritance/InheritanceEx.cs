using System;

namespace _74_Inheritance
{
    class GrandFather
    {
        public int money = 10000000;
        public void wealth()
        {
            Console.WriteLine("현금{0}을 가졌다", money);
        }
    }
    // Father는 GrandFather를 상속했다.
    class Father : GrandFather
    {
        public int score = 99;
        public void study()
        {
            Console.WriteLine("IT 점수 {0}", score);
        }
    }
    class child : Father
    {
        public string office = "부산시장";
        public void run()
        {
            Console.WriteLine(office + "역할을 잘 수행하다");
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
            Console.WriteLine();

            Father father = new Father();
            Console.WriteLine("---{0}---", father);
            Console.WriteLine(father.money);
            father.wealth();
            Console.WriteLine(father.score);
            father.study();
            Console.WriteLine();

            child child = new child();
            Console.WriteLine("---{0}---", child);
            Console.WriteLine(child.money);
            child.wealth();
            Console.WriteLine(child.score);
            child.study();
            Console.WriteLine(child.office);
            child.run();
        }
    }
}

