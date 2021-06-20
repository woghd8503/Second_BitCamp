using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    //여기서의 StarUnit의 역할
    //    1) 스타크래프트 유닛의 특징을 정의하는데 사용(상속)
    //    2) 배열등으로 자식 객체를 묶어서 관리할 수 있다
    //    3) 메서드의 매개변수로 사용되면서 모든 자식객체를
    //       일원화하여 전달할  수 있다.

    //    * 실질적인 게임성/재미/특성에는 구현내용을 사용되지 않는다.

    //    => 위와 같은 경우는 굳이 구현 클래스로 만들 필요가 없다
    //        어차피 객체를 만들 목적이 아니므로
    //        추상클래스/인터페이스로 만들어도 무방하다(더 낫다)
    class Scv : StarUnit
    {
        public void attack()
        {
            Console.WriteLine("징~지징");
        }
        public void move()
        {
            Console.WriteLine("슈우웅~");
        }
        public void die()
        {
            Console.WriteLine("퍼엉~");
        }
    }
}
