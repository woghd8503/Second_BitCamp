using System;

//[class 내부에 메서드를 선언하고 사용하는 2가지 방법]
//1. 메서드에 static을 붙여준다
//    static 메모리에 바로 로딩된다.
//    즉시 사용가능
//    *범용적인 기능을 정의할 때

//2. 메서드에 static을 안붙인다.
//    반드시 클래스 객체(변수)를 생성하고 
//    객체를 통해 호출한다
//    *일반적인 프로그래밍 시

namespace _40_StaticMethod
{
    class Calc
    {
        public int add(int a, int b)
        {
            return a + b;
        } 
        public int sub(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b)
        {
            return a * b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
    }
    class CalcEx
    {
        static void Main(string[] args)
        {
            Calc clac = new Calc();
            int result = 0;
            result = clac.add(10, 5);
            Console.WriteLine("+=" + result);
            result = clac.sub(10, 5);
            Console.WriteLine("-=" + result);            
            result = clac.mul(10, 5);
            Console.WriteLine("*=" + result);            
            result = clac.div(10, 5);
            Console.WriteLine("/=" + result); 
        }
    }
}
