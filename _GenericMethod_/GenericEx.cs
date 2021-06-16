using System;

namespace _123_GenericMethod
{
    class GenericMethodEx
    {
        // Call by Value
        // 기본자료형(구조체)는 지역변수일 때
        // 스택에 올라간다
        // 메서드에 전달될 때 값이 복사된다.
        // a와 b가 num1, num2를 의미하는 것이
        // 아니라 num1, num2에 있던
        // 10, 20만 복사된다.
        // 그러므로 실제 num1, num2의 값이
        // 바뀌지 않는다.
        
        static void swap(ref int a,ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        //a는 즉, num1이 된다
        //b는 즉, num2가 된다.
        static void swap(ref double a, ref double b)
        {
            double t = a;
            a = b;
            b = t;
        }
        static void Main(string[] args)
        {
            int num1 = 10, num2 = 20;
            swap(ref num1, ref num2);
            Console.WriteLine("num1:" + num1);
            Console.WriteLine("num2:" + num2);

            double dnum1 = 3.5, dnum2 = 7.8;
            swap(ref dnum1, ref dnum2);
            Console.WriteLine("dnum1:" + dnum1);
            Console.WriteLine("dnum2:" + dnum2);
        }
    }
}
