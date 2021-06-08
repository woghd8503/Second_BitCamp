using System;

namespace _68_Property
{
    class Student
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
            }
        }
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
