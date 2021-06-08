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
            //attack() 메서드를 호출할 때
            //virtual 키워드가 없으면
            //컴파일러는 클래스 타입으로
            //attack() 메서드 호출을 결정한다.
            //(virtual이 없으면 객체와 무관하게
            //클래스 타입에 의해 attack메서드가 결정된다.)
            //컴파일 시 결정 되므로 이것을
            // '정적 바인딩'이라 부른다.

            for (int i = 0; i < cnt; i++)
                starUnit.attack();
        }
        static void Main(string[] args)
        {
            // 부모 클래스 변수 = 자식 객체
            // 1) 묶어서 관리하기가 용이하니까
            // 2) 매개변수로 넘길 때 부모 클래스 변수로 사용가능
                
            StarUnit[] starArr = new StarUnit[3];
            starArr[0] = new StarUnit();
            starArr[1] = new Marine();
            starArr[2] = new Hydra();
            attackCount(starArr[0], 3);
            attackCount(starArr[1], 5);
            attackCount(starArr[2], 7);
        }
    }
}
