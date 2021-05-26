using System;

namespace _36_Class
{
    class Student
    {
        public string name;
        public int age;
        public void intro()
        {
            Console.WriteLine("이름: " + name);
            Console.WriteLine("나이: " + age);
        }
    }
    class ClassEx
    {
        static void Main(string[] args)
        {
            // 클래스 -> 객체(인스턴스)
            // 설계도 -> 메모리 올라간 변수
            // 자료형 -> 변수
            // 진도개 -> 덕구
            // int num = 10;
            // int = 10;
            Student kim = new Student();
            kim.name = "홍길동";
            kim.age = 25;
            kim.intro();
        }
    }
}
