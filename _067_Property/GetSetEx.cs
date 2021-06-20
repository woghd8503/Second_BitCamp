using System;

//프로퍼티의 탄생
//    1) 객체지향의 원칙은 지켜져야 한다.
//    2) 필드의 변화와 메서드의 동작을 구분하는 가독성을 향상시켜야 한다.
//    3) 필드는 소문자로 시작, 프로퍼티는 대문자로 시작하는 변수명을 갖는 것을 원칙으로 한다.
//    4) 사용시에는 필드처럼 사용
//      실제 내부적으로는 getter/setter 메서드로 사용
namespace _65_Getter_setter
{
    class Time
    {
        private int hour;

        public int Hour
        {
            get { return this.hour; }
            set
            {
                if (value < 24)
                    this.hour = value;
            }
        }
        public void outTime()
        {
            Console.WriteLine("현재 시간은 {0}입니다.", hour);
        }
    }
    class GetSetEx
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.Hour = 12;
            time.outTime();

            time.Hour = 79;
            time.outTime();
            Console.WriteLine(time.Hour);
        }
    }
}
