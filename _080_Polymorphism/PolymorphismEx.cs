using System;

namespace _79_Polymorphism
{
    class StarUnit
    {
        public void attack() { Console.WriteLine("attack~"); }
    }
    class Marine : StarUnit
    {
        public void attack() { Console.WriteLine("두두두두~"); }
    }
    class Hydra : StarUnit
    {
        public void attack() { Console.WriteLine("퉤앳~"); }
    }
    class PolymorphismEx
    {
        static void attackCount(StarUnit starUnit, int cnt)
        {
            for (int i = 0; i < cnt; i++)
                starUnit.attack();
        }
        static void attackCount(Marine marine, int cnt)
        {
            for (int i = 0; i < cnt; i++)
                marine.attack();
        }
        static void attackCount(Hydra hydra, int cnt)
        {
            for (int i = 0; i < cnt; i++)
                hydra.attack();
        }
        static void Main(string[] args)
        {
            // 부모 클래스 변수 = 자식 객체
            // 1) 묶어서 관리하기가 용이하니까
            // 2) 매개변수로 넘길 때 부모 클래스 변수로 사용가능
            
            //유닛들이 계속 증가할 때마다
            //    해당 attackCount메서드도 추가해야 한다
            //    => 코드를 손댈 것이 많다
            //    => 100개 유닛 증가 => 100개 메서드도 증가
            StarUnit starUnit = new StarUnit();
            Marine marine = new Marine();
            Hydra hydra = new Hydra();
            attackCount(starUnit, 3);
            attackCount(marine, 5);
            attackCount(hydra, 7);
        }
    }
}
