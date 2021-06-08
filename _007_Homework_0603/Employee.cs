using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Homework_0603_Solve
{
    abstract class Employee
    {
        public string CompanyNum { get; set; }
        public string Name { get; set; }
        public int Pay { get; set; }

        public Employee(string companyNum, string name, int pay) // 생성자
        {
            this.CompanyNum = companyNum;
            this.Name = name;
            this.Pay = pay;
        }
        public virtual void showEmployeeInfo()
        {
            Console.WriteLine("사번 : " + this.CompanyNum);
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("보수 : " + this.Pay);
        }
        public abstract double getMonthDay();
    }
}
