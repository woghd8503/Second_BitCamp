using System;

//[접근권한]
//;해당class외부에서 class내부의 필드/메서드를
//접근할 수 있는 권한
//private: class내의 메서드만 접근 가능
//public: 모든 메서드가 접근 가능

//필드(변수)를 직접 접근하기 보다
//다른 방식으로 접근하는 3가지 방법
//    1) 생성자 메소드를 사용

namespace _37_Class
{
    class Student
    {
        private string name;
        private int age;

        //[생성자 메서드]
        //; 리턴형이 없다
        //  클래스 이름과 동일하다
        //  객체 생성시 자동 호출되는 메서드

        public Student(string name, int age)
        {
            Console.WriteLine("생성자 메서드 호출");
            // 필드변수 = 매개변수
            this.name = name;
            this.age = age;
        }
        public void intro()
        {
            //name으로 해도 매개변수에 name이 없으므로
            //자동으로 필드 name을 지칭하게 된다
            //this.name을 사용해도 된다.
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
        }
    }
    class ClassEx
    {
        static void Main(string[] args)
        {
            // 객체 생성시 생성자 메서드 자동 호출
            Student kim = new Student("홍길동", 25);
            kim.intro();
        }
    }
}
