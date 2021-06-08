using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Homework_0603_Solve
{
    class TempEmployee : Employee
    {
        public int HireYear { get; set; }

        public TempEmployee(string companyNum, string name, int pay, int hireYear)
            : base(companyNum, name, pay)
        {
            this.HireYear = hireYear;
        }

        public override double getMonthDay()
        {
            return (double)this.Pay / 12;
        }

        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("고용기간(년) : " + this.HireYear);
            Console.WriteLine("월급 : " + getMonthDay());
        }
    }
}
