using System;
//[객체지향 프로그래밍의 원칙]
//1. 필드는 private
//2. 메서드는 public
//3. 필드의 값의 입력/출력은
//    getter/setter를 사용한다
//4. 메서드중에 클래스내부에서만
//    쓰이는 메서드는 private 으로 전환


namespace _65_Getter_setter
{
    class Time
    {
        public int hour;
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
            time.hour = 12;
            time.outTime();

            time.hour = 79;
            time.outTime();
        }
    }
}
