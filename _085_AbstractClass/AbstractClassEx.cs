using System;

namespace _85_AbstractClass
{
    //현재 Class 단계에서는 구체화하기 어려운 상황
    //구현하기 어려운 메서드를 선언만하고
    //상속시켜서 구현하도록 하는 클래스 => 추상 클래스
    //구현하기 어려운 메서드 => 추상 메서드

    //abstract는 자동으로 virtual의 특징을 내제한다.
    abstract class Animal
    {
        public void  eat() { Console.WriteLine("밥을 먹다"); }
        public void sleep() { Console.WriteLine("잠을 자다"); }
        public abstract void sound();
    }

    class Cat : Animal
    {
        public override void sound() { Console.WriteLine("야옹~"); }
    }
    class Dog : Animal
    {
        public override void sound() { Console.WriteLine("멍멍~"); }
    }
    class Cow : Animal
    {
        public override void sound() { Console.WriteLine("음메~"); }
    }

    class AbstractClassEx
    {
        static void Main(string[] args)
        {
            /*
            객체 == 인스턴스
            클래스 => 객체 (인스턴스화 시켰다)
            추상 클래스는 객체화할 수 없다
            Animal animal = new Animal();
            */

            Animal[] animalArr = new Animal[3];
            animalArr[0] = new Cat();
            animalArr[1] = new Dog();
            animalArr[2] = new Cow();

            sound(animalArr[0], 3);
            sound(animalArr[1], 5);
            sound(animalArr[2], 7);
        }

        static void sound(Animal animal, int count)
        {
            for (int i = 0; i < count; i++)
                animal.sound();
        }
    }
}
