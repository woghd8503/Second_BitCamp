using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Homework_0525
{
    class Address
    {
        public string name;
        public string phoneNum;
        public string address;
    }
    class Menu
    {
        public void SelMenu()
        {
            AddressManager addMrg = new AddressManager();
            while (true)
            {
                Console.Clear();
                ShowMenu();
                int sel = GetSelNum();

                switch (sel)
                {
                    case 0:
                        addMrg.EnrolInfo();
                        break;
                    case 1:
                        addMrg.SearchInfo();
                        break;
                    case 2:
                        addMrg.UpdateInfo();
                        break;
                    case 3:
                        addMrg.DeleteInfo();
                        break;
                    case 4:
                        addMrg.PrintAll();
                        break;
                    case 5:
                        Exit();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                Console.ReadKey();
            }
            void Exit()
            {
                Environment.Exit(0);
            }
        }
        public void ShowMenu()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("0. 주소 등록");
            Console.WriteLine("1. 주소 검색");
            Console.WriteLine("2. 주소 수정");
            Console.WriteLine("3. 주소 삭제");
            Console.WriteLine("4. 주소 전체 출력");
            Console.WriteLine("5. 종료");
            Console.WriteLine("------------------------");
        }
        public int GetSelNum()
        {
            int selNum = -1;
            Console.WriteLine("원하시는 번호를 입력하세요");
            selNum = Int32.Parse(Console.ReadLine());
            return selNum;
        }
    }

    class AddressManager
    {
        List<Address> info = new List<Address>();
        string name;
        string phoneNum;
        string address;
        public void EnrolInfo()
        {
            ClearView();
            Console.WriteLine("이름을 입력:");
            name = Console.ReadLine();
            Console.WriteLine("폰번호 입력:");
            phoneNum = Console.ReadLine();
            Console.WriteLine("주소를 입력:");
            address = Console.ReadLine();
            Address book = new Address();
            book.name = name;
            book.address = address;
            book.phoneNum = phoneNum;
            info.Add(book);
        }
        public void SearchInfo()
        {
            ClearView();
            NoInfo();
            Console.WriteLine("검색할 이름을 입력하세요");
            string name = Console.ReadLine();
            for (int i = 0; i < info.Count; i++)
            {
                if (name == info[i].name)
                {
                    Console.WriteLine("이름: {0}", info[i].name);
                    Console.WriteLine("번호: {0}", info[i].phoneNum);
                    Console.WriteLine("주소: {0}", info[i].address);
                }
                else if (name != info[i].name)
                {
                    Console.Clear();
                    Console.WriteLine("일치하는 정보가 없습니다.");
                }
            }
            Console.ReadKey();
        }
        public void UpdateInfo()
        {
            ClearView();
            NoInfo();
            Console.WriteLine("수정할 이름을 입력하세요:");
            string name = Console.ReadLine();
            for (int i = 0; i < info.Count; i++)
            {
                if (name == info[i].name)
                {
                    Console.WriteLine("변경할 이름을 입력하세요");
                    string nName = Console.ReadLine();
                    Console.WriteLine("변경할 폰번호를 입력하세요");
                    string phoneNum = Console.ReadLine();
                    Console.WriteLine("변경할 주소을 입력하세요");
                    string address = Console.ReadLine();
                    info[i].name = nName;
                    info[i].phoneNum = phoneNum;
                    info[i].address = address;
                    Console.WriteLine("변경이 완료되었습니다.");
                }
                else if (name != info[i].name)
                {
                    Console.WriteLine("일치하는 정보가 없습니다.");
                }
            }
            Console.ReadKey();
        }
        public void DeleteInfo()
        {
            ClearView();
            NoInfo();
            Console.WriteLine("이름입력");
            string name = Console.ReadLine();
            for (int i = 0; i < info.Count; i++)
            {
                if (name == info[i].name)
                {
                    Console.WriteLine("이름은: {0}", info[i].name);
                    Console.WriteLine("번호는: {0}", info[i].phoneNum);
                    Console.WriteLine("주소는: {0}", info[i].address);
                    Console.WriteLine("정말 삭제를 하시 겠습니다. [Y/N]");
                    string input = Console.ReadLine();
                    if (input == "Y")
                    {
                        info.RemoveAt(i);
                    }
                    else if (input == "N")
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
        public void PrintAll()
        {
            ClearView();

            for (int i = 0; i < info.Count; i++)
            {
                Console.WriteLine("-------------{0}--------", i);
                Console.WriteLine("이름은: {0}", info[i].name);
                Console.WriteLine("번호는: {0}", info[i].phoneNum);
                Console.WriteLine("주소는: {0}", info[i].address);
            }
            NoInfo();
            Console.ReadKey();
        }
        public void Exit()
        {
            ClearView();
            Console.WriteLine("종료");
        }
        public void NoInfo()
        {
            if (info.Count == 0)
            {
                Console.WriteLine("입력된 주소가 없습니다.");
            }
        }

        public void ClearView()
        {
            Console.Clear();
        }

    }

    class AddressMvc
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.SelMenu();
        }
    }
}
