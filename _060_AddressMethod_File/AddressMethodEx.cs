using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/*
[주소록 프로젝트]
1. 메서드 단위로 설계한다는 것은 기능단위로 나누는 것
2. 기능 정의
  1) 메뉴 출력
    void printMenu();
  2) 메뉴 선택
    int selectMenu();
  3) 주소 정보 입력(이름, 전화번호, 주소)
    void insertAddress();
  4) 주소 정보 검색(이름으로 검색 후 정보출력)
    void searchAddress();
  5) 주소 정보 변경(이름으로 검색 후 변경)
    void updateAddress();
  6) 주소 정보 삭제(이름으로 검색 후 삭제)
    void deleteAddress();
  7) 주소 정보 전체 출력
    void printAllAddress();
  8) 파일 로딩
    void loadFileAddress();
  9) 파일 저장
    void SaveFileAddress();
  8) 종료
    void programExit();
  9) 화면 지우기
    void clearScreen();
  10) 메뉴 반복 루프
    void mainLoop();
*/
namespace _59_AddressMethod
{
    class Address
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Addr { get; set; }

        public void showInfo(int order)
        {
            Console.WriteLine("\n------{0}------", order);
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("전화 : " + this.Phone);
            Console.WriteLine("주소 : " + this.Addr);
        }
        public void showInfo()
        {
            Console.WriteLine("이름 : " + this.Name);
            Console.WriteLine("전화 : " + this.Phone);
            Console.WriteLine("주소 : " + this.Addr);
        }
    }
    class AddressMethodEx
    {
        static ArrayList arrList = new ArrayList();

        static void printMenu()
        {
            Console.WriteLine("=================");
            Console.WriteLine("1. 주소 입력");
            Console.WriteLine("2. 주소 검색");
            Console.WriteLine("3. 주소 수정");
            Console.WriteLine("4. 주소 삭제");
            Console.WriteLine("5. 주소 전체 출력");
            Console.WriteLine("6. App 종료");
            Console.WriteLine("=================");
        }

        static int selectMenu()
        {
            int sel = 0;

            Console.Write("메뉴 선택 >> ");
            sel = Int32.Parse(Console.ReadLine());

            return sel;
        }

        static void insertAddress()
        {
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

            arrList.Add(address);
        }

        static Address searchAddress(string title)
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

        static void searchAddress()
        {
            Address address = searchAddress("주소 검색");
            if(address != null)
                address.showInfo();
            else
                Console.WriteLine("검색 대상이 없습니다...");

            Console.ReadLine();
        }

        static void updateAddress()
        {
            Address address = searchAddress("주소 수정");
            if (address != null)
            {
                Console.Write("수정 이름: ");
                string name = Console.ReadLine();
                Console.Write("수정 전화: ");
                string phone = Console.ReadLine();
                Console.Write("수정 주소: ");
                string addr = Console.ReadLine();
                address.Name = name;
                address.Phone = phone;
                address.Addr = addr;
                address.showInfo();
            }
            else
                Console.WriteLine("수정 대상이 없습니다...");

            Console.ReadLine();
        }

        static void deleteAddress()
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

        static void printAllAddress()
        {
            for(int i = 0; i < arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                address.showInfo(i + 1);
            }
            Console.ReadLine();
        }

        static void loadFileAddress()
        {
            StreamReader sr = null;
            //파일입출력/DB 연결/Network통신 등 우리 프로그램
            //내부가 아니라 외부시스템 /HW와 연결되어야 할 상황에
            //만약 발생할 수 있는 예외상황을 대비하기 위한 처리

            try // 코드 실행을 시도한다
            {
                sr = new StreamReader("address.txt");
                Address address = null;
                int step = 0;
                while (sr.Peek() >= 0) // 읽을 내용이 있다.
                {
                    string str = sr.ReadLine();
                    if (step == 0)
                    {
                        address = new Address();
                        address.Name = str;
                        step++;
                    }
                    else if (step == 1)
                    {
                        address.Phone = str;
                        step++;
                    } else if(step == 2)
                    {
                        address.Addr = str;
                        step++;
                    }else
                    {
                        step = 0;
                        arrList.Add(address);
                    }
                }
            }
            catch (Exception e) // 예외 에러를 잡는다.
            {
                Console.WriteLine(e.Message);    // 원인 파악
                Console.WriteLine(e.StackTrace); // 위치

            }
            finally // 정성 or 예외든 무조건 마무리한다.
            {
                if(sr != null)
                sr.Close();
            }
        }
        static void saveFileAddress()
        {
            StreamWriter sw = new StreamWriter("address.txt");
            for(int i = 0; i< arrList.Count; i++)
            {
                Address address = (Address)arrList[i];
                sw.WriteLine(address.Name);
                sw.WriteLine(address.Phone);
                sw.WriteLine(address.Addr);
                sw.WriteLine();
            }

            sw.Close();
        }
        static void programExit()
        {
            saveFileAddress();
            Console.WriteLine("안녕히 계세요~");
        }

        static void clearScreen()
        {
            Console.Clear();
        }

        static void mainLoop()
        {
            loadFileAddress();

            bool isRun = true;
            while (isRun)
            {
                clearScreen();  // 화면지우기
                printMenu();    // 메뉴 출력
                int sel = selectMenu();//번호 선택

                clearScreen();
                switch (sel)
                {
                    case 1:
                        insertAddress();
                        break;
                    case 2:
                        searchAddress();
                        break;
                    case 3:
                        updateAddress();
                        break;
                    case 4:
                        deleteAddress();
                        break;
                    case 5:
                        printAllAddress();
                        break;
                    case 6:
                        isRun = false;
                        programExit();
                        break;
                    default:
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            mainLoop();
        }
    }
}
