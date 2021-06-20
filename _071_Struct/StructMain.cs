using System;

namespace _70_Struct
{
    struct Student
    {
        private string name;
        private int age; 

        // 생성자 (변수(객체))가 선언할 때 자동호출되는
        // 메서드
        public Student(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void outInfo()
        {
            Console.WriteLine("이름:" + name);
            Console.WriteLine("나이:" + age);
        }
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
            // 생성자를 호출하기 위한 표현 방식일 뿐
            // Stack에 올라간다
            Student st = new Student("홍길동", 24);
            st.outInfo();
        }
    }
}
