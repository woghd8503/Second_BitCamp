using System;

//struct와 class의 공통점과 차이점
//    1) 공통점 
//    둘다 필드와 메서드를 포함하는 사용자 정의 타입이다
//    2) 차이점
//      2-1) class는 상속이 가능
//           struct는 상속이 불가능
//      2-2) 지역변수에는 사용할 때
//           class는 Heap에 생성되고
//           struct는 Stack에 생성된다.
//      2-3) class는 class 키워드로 선언하거나
//                   string, 배열이 class이다
//         struct는 struct 키워드로 선언하거나
//                기본자료형인 int, double, char...
//                이다.
//
//      2-4) class는 new로 객체를 생성하고
//           struct는 그냥 변수만 선언하고 생성된다.

namespace _70_Struct
{
    struct Student
    {
        public string Name;
        public int Age; 
    }
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class StructMain
    {
        static void Main(string[] args)
        {
            Student st;                 // stack
            Human human = new Human();  // heap
            st.Name = "홍길동";
            st.Age = 24;
            human.Name = "임꺽정";
            human.Age = 33;

            Console.WriteLine(st.Name + ":" + st.Age);
            Console.WriteLine(human.Name + ":" + human.Age);
        }
    }
}
