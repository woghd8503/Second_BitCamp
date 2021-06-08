using System;
//Auto Property
//자동으로 프로퍼티에 대응되는
//익명 field와 getter/setter가
//생성된다
namespace _68_Property
{
    class Student
    {
        private int age;
        public string Name {get;set;}
        public int Age
        {
            get { return this.age; }
            set
            {
                if(value >= 0) 
                this.age = value;
            }
        }
    }
    class PropertyEx
    {
        static void Main(string[] args)
        {
            Student st = new Student();
            st.Name = "홍길동";
            st.Age = 27;
            Console.WriteLine(st.Name);
            Console.WriteLine(st.Age);
        }
    }
}