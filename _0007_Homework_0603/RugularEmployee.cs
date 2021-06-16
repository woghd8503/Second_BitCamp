using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Homework_0603_Solve
{
    class RegularEmployee : Employee
    {
        //자식객체가 생성되기 전에
        //부모객체가 먼저 생성된다
        //즉, 자식 생성자가 호출되기 전에
        //부모 생성자가 먼저 호출된다
        //그러므로 부모 생성자의 매개변수를 
        //자식생성자에게 전달해줘야 한다
        //base는 부모의 생성자를 의미한다.

        public int Bonus { get; set; }

        public RegularEmployee(string companyNum, string name, int pay, int bonus)
            : base(companyNum, name, pay)
        {
            this.Bonus = bonus;
        }
        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("보너스 : " + this.Bonus);
            Console.WriteLine("월급 : " + getMonthDay());

        }

        public override double getMonthDay()
        {
            return (double)this.Pay / 12 + (double)this.Bonus / 12;

        }
    }
}
