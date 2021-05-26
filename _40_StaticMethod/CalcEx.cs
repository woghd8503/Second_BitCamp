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
        public static int add(int a, int b)
        {
            return a + b;
        } 
        public static int sub(int a, int b)
        {
            return a - b;
        }
        public static int mul(int a, int b)
        {
            return a * b;
        }
        public static int div(int a, int b)
        {
            return a / b;
        }
    }
    class CalcEx
    {
        static void Main(string[] args)
        {
            int result = 0;
            result = Calc.add(10, 5);
            Console.WriteLine("+=" + result);
            result = Calc.sub(10, 5);
            Console.WriteLine("-=" + result);            
            result = Calc.mul(10, 5);
            Console.WriteLine("*=" + result);            
            result = Calc.div(10, 5);
            Console.WriteLine("/=" + result); 
        }
    }
}
