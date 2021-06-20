using System;

namespace _38_Class
{
    //[접근권한]
    //;해당class외부에서 class내부의 필드/메서드를
    //접근할 수 있는 권한
    //private: class내의 메서드만 접근 가능
    //public: 모든 메서드가 접근 가능

    //필드(변수)를 직접 접근하기 보다
    //다른 방식으로 접근하는 3가지 방법
    //    1) 생성자 메소드를 이용
    //    2)  getter/setter를 이용
    class Student
    {
        private string name;
        private int age;

        public string getName()
        {
            return this.name;
        }
        public int getAge()
        {
            return this.age;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setAge(int age)
        {
            if(age >= 0)
            this.age = age;
        }

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
            // 객체 생성시 생성자 메서드 자동 호출
            Student kim = new Student();
            kim.setName("홍길동");
            kim.setAge(25);
            kim.intro();
        }
    }
}
