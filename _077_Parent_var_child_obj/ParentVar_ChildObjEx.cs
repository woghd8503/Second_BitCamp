using System;
/*[객체지향 언어가 가지는 공통 특징]
=> 부모 클래스 변수에 자식 객체를 저장할 수 있다*/
namespace _77_Parent_var_child_obj
{
    class Animal { }
    class Feline : Animal { }
    class Canine : Animal { }
    class Cat : Feline { }
    class Tiger : Feline { }
    class Lion : Feline { }
    class Dog : Canine { }
    class Wolf : Canine { }
    class Jindo : Dog { }

    class ParentVar_ChildObjEx
    {
        static void Main(string[] args)
        {
            Animal[] animalArr = new Animal[8];
            animalArr[0] = new Feline();
            animalArr[1] = new Canine();
            animalArr[2] = new Cat();
            animalArr[3] = new Tiger();
            animalArr[4] = new Lion();
            animalArr[5] = new Dog();
            animalArr[6] = new Wolf();
            animalArr[7] = new Jindo();

            foreach (Animal animal in animalArr)
                Console.WriteLine(animal);
        }
    }
}
