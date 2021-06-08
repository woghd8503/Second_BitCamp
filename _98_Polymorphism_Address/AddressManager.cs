using _98_polymorphism_Address;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _61_AddressClass
{
    class AddressManager
    {
        ArrayList arrList = new ArrayList();
        AddressFile addrFile = new AddressFile();

        public void initAddress() 
        {
            addrFile.loadFileAddress(arrList);
        }
        public void insertAddress() 
        {
            Console.WriteLine("---주소 입력---");
            Console.WriteLine("1.일반   2.대학   3.회사");
            Console.Write("번호 선택 >> ");
            int sel = Int32.Parse(Console.ReadLine());
            string name, phone, addr;
            string major, year;
            string company, job;
            Address address;

            Console.Write("이름 입력 >> ");
            name = Console.ReadLine();
            Console.Write("전화 입력 >> ");
            phone = Console.ReadLine();
            Console.Write("주소 입력 >> ");
            addr = Console.ReadLine();
            if(sel == 1)
            {
                address = new Address();
                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;

                arrList.Add(address);
            }
            else if(sel == 2)
            {
                Console.Write("전공 입력 >> ");
                major = Console.ReadLine();
                Console.Write("학년 입력 >> ");
                year = Console.ReadLine();

                address = new UnivAddress();
                ((UnivAddress)address).Name = name;
                ((UnivAddress)address).Phone = phone;
                ((UnivAddress)address).Addr = addr;
                ((UnivAddress)address).Major = major;
                ((UnivAddress)address).Year = year;

                arrList.Add(address);
            }
            else if(sel == 3)
            {
                Console.Write("회사 입력 >> ");
                company = Console.ReadLine();
                Console.Write("업무 입력 >> ");
                job = Console.ReadLine();

                address = new CompanyAddress();
                ((CompanyAddress)address).Name = name;
                ((CompanyAddress)address).Phone = phone;
                ((CompanyAddress)address).Addr = addr;
                ((CompanyAddress)address).Company = company;
                ((CompanyAddress)address).Job = job;

                arrList.Add(address);
            }
        }
        public Address searchAddress(string title)
        {
            Console.WriteLine("------{0}------", title);
            Console.Write("검색할 이름 입력 >> ");
            string name = Console.ReadLine();
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                if (address.Name == name)    // 찾았다
                {
                    return address;
                }
            }
            return null;
        }
        public void searchAddress() 
        {
            Address address = searchAddress("주소 검색");
            if (address != null)
                address.showInfo();
            else
                Console.WriteLine("검색 대상이 없습니다...");

            Console.ReadLine();
        }
        public void updateAddress() 
        {
            Address address = searchAddress("주소 수정");
            if (address != null)
            {
                string name, phone, addr;
                string major, year;
                string company, job;

                Console.Write("수정 이름: ");
                name = Console.ReadLine();
                Console.Write("수정 전화: ");
                phone = Console.ReadLine();
                Console.Write("수정 주소: ");
                addr = Console.ReadLine();

                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;

                if (address is UnivAddress)
                {
                    Console.Write("수정 전공: ");
                    major = Console.ReadLine();
                    Console.Write("수정 학년: ");
                    year = Console.ReadLine();

                    ((UnivAddress)address).Major = major;
                    ((UnivAddress)address).Year = year;
                }
                else if(address is CompanyAddress)
                {
                    Console.Write("수정 회사: ");
                    company = Console.ReadLine();
                    Console.Write("수정 업무: ");
                    job = Console.ReadLine();

                    ((CompanyAddress)address).Company = company;
                    ((CompanyAddress)address).Job = job;
                }
                
                address.showInfo();
            }
            else
                Console.WriteLine("수정 대상이 없습니다...");

            Console.ReadLine();
        }
        public void deleteAddress() 
        {
            Address address = searchAddress("주소 삭제");
            if (address != null)
            {
                address.showInfo();
                Console.Write("진짜 삭제하시겠습니까(y/n) >> ");
                string answer = Console.ReadLine();

                if (answer == "y" || answer == "Y")
                    arrList.Remove(address);
                else
                    Console.WriteLine("삭제가 취소되었습니다~");
            }
            else
                Console.WriteLine("삭제 대상이 없습니다...");

            Console.ReadLine();
        }
        public void printAllAddress() 
        {
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                address.showInfo(i + 1);
            }
            Console.ReadLine();
        }
        public void programExit() 
        {
            addrFile.saveFileAddress(arrList);
            Console.Write("프로그램 종료~");
            Console.ReadLine();
        }
    }
}
