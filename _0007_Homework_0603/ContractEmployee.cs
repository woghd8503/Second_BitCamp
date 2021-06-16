using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Homework_0603_Solve
{
    class ContractEmployee : Employee
    {
        public int WorkDay { get; set; }
        public ContractEmployee(string companyNum, string name, int pay, int workDay)
    : base(companyNum, name, pay)
        {
            this.WorkDay = workDay;
        }

        public override double getMonthDay()
        {
            return (double)this.Pay * this.WorkDay;
        }

        public override void showEmployeeInfo()
        {
            base.showEmployeeInfo();
            Console.WriteLine("일한 일수 : " + this.WorkDay);
            Console.WriteLine("월급 : " + getMonthDay());

        }
    }
}
