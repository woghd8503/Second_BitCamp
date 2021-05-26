using System;
using System.Collections;

/*[주소록 프로젝트]
1. 메서드 단위로 설계한다는 것은 기능단위로 나누는 것

2. 기능 정의
    1) 메뉴 출력
        void PrintMenu();
    2) 메뉴 선택
        int SelectMenu();
    3) 주소 정보 입력(이름, 전화번호, 주소)
        void InsertAddress();
    4) 주소 정보 검색(이름으로 검색)
        void SearchAddress();
    5) 주소 정보 변경(이름으로 검색 후 변경)
        void UpdateAddress();
    6) 주소 정보 삭제(이름으로 검색 후 삭제)
        void DeleteAddress();
    7) 주소 정보 전체 출력
        void PrintAllAddress();
    8) 종료
        void ProgramExit();
    9) 화면 지우기
        void ClearScreen();
    10) 메뉴 반복 루프
        void MainLoop();*/
namespace _59_AddressMethod
{
    class Address
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }
    }
    class AddressMethodEx
    {
        static ArrayList arrList = new ArrayList();
        static void PrintMenu()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체 출력");
            Console.WriteLine("6. 주소 App 종료");
        }
        static int SelectMenu()
        {
            int sel = 0;

            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }
        static void InsertAddress()
        {
            ClearScreen();
            Console.WriteLine("---주소 입력---");
            Console.Write("이름 입력 >> ");
            string name = Console.ReadLine();
            Console.Write("전화 입력 >> ");
            string phone = Console.ReadLine();
            Console.Write("주소 입력 >> ");
            string addr = Console.ReadLine();

            Address address = new Address();
            address.Name = name;
            address.Phone = phone;
            address.Addr = addr;
        }
        static void SearchAddress()
        {

        }
        static void UpdateAddress()
        {

        }
        static void DeleteAddress()
        {

        }
        static void PrintAllAddress()
        {
            for (int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                Console.WriteLine("\n--------{0}--------", i + 1);
                Console.WriteLine("이름 : " + address.Name);
                Console.WriteLine("전화 : " + address.Phone);
                Console.WriteLine("주소 : " + address.Addr);
            }
            Console.ReadLine();
        }
        static void ProgramExit()
        {
            Console.WriteLine("안녕히 계세요~");
        }
        static void ClearScreen()
        {
            Console.Clear();
        }
        static void MainLoop()
        {
            bool isRun = true;
            while (isRun)
            {
                ClearScreen();  // 화면지우기
                PrintMenu();    // 메뉴 출력
                int sel = SelectMenu(); // 번호 선택

                ClearScreen();
                switch (sel)
                {
                    case 1:
                        InsertAddress();
                        break;
                    case 2:
                        SearchAddress();
                        break;
                    case 3:
                        UpdateAddress();
                        break;
                    case 4:
                        DeleteAddress();
                        break;
                    case 5:
                        PrintAllAddress();
                        break;
                    case 6:
                        isRun = false;
                        ProgramExit();
                        break;
                    default:
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            PrintMenu();
            SelectMenu();
            InsertAddress();
            SearchAddress();
            UpdateAddress();
            DeleteAddress();
            PrintAllAddress();
            ProgramExit();
            ClearScreen();
            MainLoop();
        }
    }
}
