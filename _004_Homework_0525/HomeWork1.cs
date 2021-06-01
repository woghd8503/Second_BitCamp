using System;
using System.Collections.Generic;
using System.Text;

namespace _004_Homework_0525
{
    //1. 밑변과 높이 정보를 저장할 수 있는 Triangle클래스를 정의합니다
    //   생성과 동시에 초기화가 가능한 생성자도 정의합니다
    //   밑변과 높이 정보를 변경시킬 수 있는 메소드를 정의합니다
    //   삼각형의 넓이를 계산해서 반환하는 메소드도 정의합니다
    //   객체를 만들어서 사용해보세요

    //2. 노래를 나타내는 Song이라는 클래스를 설계하세요.
    //   <필드>
    //    노래제목 title
    //    가수 artist
    //    앨범제목 album
    //    작곡가 composer
    //    노래가 발표된 연도 year
    //    노래가 속한 앨범에서의 트랙 번호를 나타내는 track

    //   <메서드>
    //    노래의 정보를 저장하는 setSongInfo(...) : 관련된 매개변수를 인자로 넘겨줌
    //    노래의 정보를 나타내는 show()

    //   <main 실행>
    //    ABBA의 "Dancing Queen"노래를 Song객체로 생성하고
    //    Show()로 출력하세요

    //3. Rectangle클래스를 작성하세요
    //   int타입의 x1, y1, x2, y2 : 사각형을 구성하는 두 점의 좌표
    //   void set(int x1, int y1, int x2, int y2) : 좌표 설정
    //   int square() : 사각형 넓이 리턴
    //   void show() : 좌표와 넓이 등 직사각형 정보의 화면 출력
    //   bool equals(Rectangle r) : 인자로 전달된 객체 r과 현 객체가 동일한 좌표의 직사각형이면 true 리턴
    class Song
    {
        public void SongList
        {
        public string title = "";
        public string artist = "";
        public string album = "";
        public string composer = "";
        public int year = 0;
        public int track = 0;
        
    
        List<> arList = new ArrayList();
        public string title = "";
        public string artist = "";
        public string album = "";
        public string composer = "";
        public int year = 0;
        public int track = 0;

        public int SetSongInfo()
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
        }

        public int Show()
        {

        }

    }

    class HomeWork1
    {
        static void Q1()
        {

        }
        static void Q2()
        {

        }


        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }
    }
}
