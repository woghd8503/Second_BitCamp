using System;

namespace _39_Class
{
    //[접근권한]
    //;해당class외부에서 class내부의 필드/메서드를
    //접근할 수 있는 권한
    //private: class내의 메서드만 접근 가능
    //public: 모든 메서드가 접근 가능

    //필드(변수)를 직접 접근하기 보다
    //다른 방식으로 접근하는 3가지 방법
    //    1) 생성자 메소드를 이용
    //    2) getter/setter를 이용
    //    3) 프로퍼티 사용(가독성 때문에 사용, 2번과 같음)

    class Student
    {
        private string name;
        private int age;

        //[프로퍼티의 특징]
        //1. 사용은 필드변수처럼 사용
        //2. 컴파일러에 의해 메서드로 변환
        //3. 프로퍼티를 만들 때 필드이름에 초성을 대문자로 만들어준다.(관습적으로)
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
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
            Student kim = new Student();
            kim.Name = "홍길동"; // setter 호출
            kim.Age = 25;       // setter 호출
            kim.intro();
            // 아래는 getter가 호출
            Console.WriteLine(kim.Name + ":" + kim.Age);

        }
    }
}
