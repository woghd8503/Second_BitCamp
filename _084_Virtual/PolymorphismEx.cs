using System;

namespace _82_Virtual
{
    class StarUnit
    {
        public virtual void attack() { Console.WriteLine("attack~"); }
    }
    class Marine : StarUnit
    {
        public override void attack() { Console.WriteLine("두두두두~"); }
    }
    class Hydra : StarUnit
    {
        public override void attack() { Console.WriteLine("퉤앳~"); }
    }
    class Tank : StarUnit
    {
        public override void attack() { Console.WriteLine("펑~"); }
    }
    class PolymorphismEx
    {
        static void attackCount(StarUnit starUnit, int cnt)
        {
            for (int i = 0; i < cnt; i++)
                starUnit.attack();
        }

        static void Main(string[] args)
        {
            /* [다형성]
            부모 클래스 변수 = 자식 객체
            1) 묶어서 관리하기가 용이하니까
            2) 매개변수로 넘길 때 부모 클래스 변수로 사용가능
            3) virtual, override를 해주면 
              클래스 변수에 따른 동작이 아니라
              객체에 따른 동작이 진행된다
            */
            /*
            유닛들이 계속 증가할 때마다
            해당 attackCount메서드도 추가해야 한다
            => 코드를 손댈 것이 많다
            => 100개 유닛 증가 => 100개 메서드도 증가
            => 기존 메서드마다 모두 계속 만들어야 한다
            */

/*          Virtual 메서드는 실행 시 객체내에 virtual table이 생성되고
            table 메서드는 등록하게 된다.

            그리고 virtual 메서드가 호출 시 객체에 등록된 해당 클래스 메서드를 호출하게 된다.*/
            StarUnit[] starArr = new StarUnit[3];
            starArr[0] = new StarUnit();
            starArr[1] = new Marine();
            starArr[2] = new Hydra();
            attackCount(starArr[0], 3);
            attackCount(starArr[1], 5);
            attackCount(starArr[2], 7);
            attackCount(new Tank(), 9);
        }
    }
}
