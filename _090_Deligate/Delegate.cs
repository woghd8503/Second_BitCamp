using System;
using System.Collections.Generic;
using System.Text;

namespace _90_Deligate
{
    //[델리게이트란] 
    //대리자, 위임자
    //메서드를 저장해서, 간접적으로 저장한 메서드를
    //호출할 수 있다.
    // 델리게이트의 선언
    delegate void func(string s);

    class DelegateEx
    {
        public static void m1(string s1)
        {
            Console.WriteLine("m1:" + s1);
        }
        public void m2(string s2)
        {
            Console.WriteLine("m2:" + s2);
        }
        static void Main(string[] args)
        {
            func f = m1;
            f("정적 메서드 호출");

            DelegateEx dEx = new DelegateEx();
            f = dEx.m2;
            f("인스턴트 메서드 호출");
        }
    }
}
