using System;
using System.Collections.Generic;
using System.Text;

namespace _007_Homework_0603_Solve
{
    class EmployeeEx
    {
        const int SAVE_REGULAR_EMPLOYEE = 1;
        const int SAVE_TEMP_EMPLOYEE = 2;
        const int SAVE_CONTRACT_EMPLOYEE = 3;
        const int PRINT_ALL_EMPLOYEE = 4;
        const int CALC_EMPLOYEE_SALARY = 5;
        const int EXIT = 6;
        
        //ArrayList와 List의 공통점과 차이점
        //    공통점 : 배열 대신 순차적으로 저장할 수 있다.
        //    차이점 : ArrayList는 object를 저장하므로 뭐든지 저장가능
        //        List<Employee> 는 Employee거나 자식객체만 저장가능
        static List<Employee> employeeList = new List<Employee>();
        static void showMenu()
        {
            Console.WriteLine("*** 메뉴 선택 ***");
            Console.WriteLine("1. 정규직 저장");
            Console.WriteLine("2. 임시직 저장");
            Console.WriteLine("3. 계약직 저장");
            Console.WriteLine("4. 전체 정보 출력");
            Console.WriteLine("5. 월급 계산 출력");
            Console.WriteLine("6. 프로그램 종료");
        }
        static int getSelMenu()
        {
            Console.Write(">> ");
            int sel = Int32.Parse(Console.ReadLine());
            return sel;
        }
        static void clearScreen()
        {
            Console.Clear();
        }
        static void mainLoop()
        {
            bool isRune = true;
            while (isRune)
            {
                clearScreen();
                showMenu();
                int sel = getSelMenu();
                switch(sel)
                {
                    case SAVE_REGULAR_EMPLOYEE:
                        saveRegularEmployee();
                        break;
                    case SAVE_TEMP_EMPLOYEE:
                        saveTempEmployee();
                        break;
                    case SAVE_CONTRACT_EMPLOYEE:
                        saveContactEmployee();
                        break;
                    case PRINT_ALL_EMPLOYEE:
                        printAllEmployee();
                        break;
                    case CALC_EMPLOYEE_SALARY:
                        calcEmployeeSalary();
                        break;
                    case EXIT:
                        break;
                }
            }
        }
        static void saveRegularEmployee()
        {
            Console.WriteLine("===정규직 입력===");
            Console.Write("사번: ");
            string companyNum = Console.ReadLine();
            Console.WriteLine("이름: ");
            string name = Console.ReadLine();
            Console.WriteLine("보수: ");
            string strPay = Console.ReadLine();
            int pay = Int32.Parse(strPay);
            Console.WriteLine("보너스: ");
            string strBonus = Console.ReadLine();
            int bonus = Int32.Parse(strBonus);

            RegularEmployee regularEmployee = new RegularEmployee(companyNum, name, pay, bonus);
            employeeList.Add(regularEmployee);
        }
        static void saveTempEmployee()
        {
            Console.WriteLine("===임시직 입력===");
            Console.Write("사번: ");
            string companyNum = Console.ReadLine();
            Console.WriteLine("이름: ");
            string name = Console.ReadLine();
            Console.WriteLine("보수: ");
            string strPay = Console.ReadLine();
            int pay = Int32.Parse(strPay);
            Console.WriteLine("고용기간(년): ");
            string strhireYear = Console.ReadLine();
            int hireYear = Int32.Parse(strhireYear);

            TempEmployee tempEmployee = new TempEmployee(companyNum, name, pay, hireYear);
            employeeList.Add(tempEmployee);
        }
        static void saveContactEmployee()
        {
            Console.WriteLine("===계약직 입력===");
            Console.Write("사번: ");
            string companyNum = Console.ReadLine();
            Console.WriteLine("이름: ");
            string name = Console.ReadLine();
            Console.WriteLine("보수: ");
            string strPay = Console.ReadLine();
            int pay = Int32.Parse(strPay);
            Console.WriteLine("일한 일수: ");
            string strWorkDay = Console.ReadLine();
            int workDay = Int32.Parse(strWorkDay);

            ContractEmployee contactEmployee = new ContractEmployee(companyNum, name, pay, workDay);
            employeeList.Add(contactEmployee);
        }
        static void printAllEmployee()
        {
            int i = 0;
            foreach(Employee emp in employeeList)
            {
                Console.WriteLine("====={0}=====", ++i);
                    emp.showEmployeeInfo();
            }
        }
        static void calcEmployeeSalary()
        {
            int i = 0;
            foreach (Employee emp in employeeList)
            {
                Console.WriteLine("====={0}=====", ++i);
                Console.WriteLine("사번: " + emp.CompanyNum());
                Console.WriteLine("이름: " + emp.Name());
                Console.WriteLine("월급: " + emp.getMonthDay());
            }
        }
        static void Main(string[] agrs)
        {
            mainLoop();
        }
    }
}
