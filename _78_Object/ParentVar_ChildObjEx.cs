using System;
/*[객체지향 언어가 가지는 공통 특징]
=> 부모 클래스 변수에 자식 객체를 저장할 수 있다
C#은 컴파일 순간에 자동으로
object의 상속을 받도록 정해져있다.
사실상의 최상위 클래스는 object 클래스이다
모든 객체는 object 변수에 담을 수 있다.
struct도 object의 상속을 받는다
그러므로 struct 변수도 object로 담을 수 있다
 */
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
            Animal[] objArr = new Animal[9];
            objArr[0] = new Feline();
            objArr[1] = new Canine();
            objArr[2] = new Cat();
            objArr[3] = new Tiger();
            objArr[4] = new Lion();
            objArr[5] = new Dog();
            objArr[6] = new Wolf();
            objArr[7] = new Jindo();
            objArr[8] = new Animal();
            

            foreach (Object obj in objArr)
                Console.WriteLine(obj);
        }
    }
}
