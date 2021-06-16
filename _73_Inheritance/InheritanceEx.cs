using System;

namespace _73_Inheritance
{
    class GrandFather
    {
        public int money = 10000000;
        public void wealth()
        {
            Console.WriteLine("현금{0}을 가졌다", money);
        }
        public void CleanScreen()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
    // Father는 GrandFather를 상속했다.
    class Father : GrandFather
    {

    }
    class Child : Father
    {

    }

    class InheritanceEx
    {
        static void Main(string[] args)
        {
            Father father = new Father();
            Console.WriteLine(father.money);
            father.wealth();
            father.CleanScreen();
            Child child = new Child();
            Console.WriteLine(child.money);
            child.wealth();
        }
    }
}

