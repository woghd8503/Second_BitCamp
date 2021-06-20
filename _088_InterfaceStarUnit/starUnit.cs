using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    //모든 메서드가 추상 메서드일 때는
    //(인터페이스라고 부른다.)
    //인터페이스와 동일하다.

    //인터페이스란?
    //모든 메서드가 추상 메서드인 클래스
    //메서드는 자동으로 public/virtual 속성을 부여받는다

    interface StarUnit
    {
        void attack();

        void move();

        void die();
    }
}
