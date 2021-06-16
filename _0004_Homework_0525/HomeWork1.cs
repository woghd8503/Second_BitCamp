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


    class Triangle
    {
        private int height = 0;
        private int bottomLine = 0;

        public Triangle(int _height = 0, int _bottomLine = 0)
        {
            this.height = _height;
            this.bottomLine = _bottomLine;
        }

        public void Input()
        {
            Console.WriteLine("높이를 입력 하시오");
            height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("밑변을 입력 하시오");
            bottomLine = Int32.Parse(Console.ReadLine());

            int result = Calc(height, bottomLine);
            Console.WriteLine("삼각형의 넓이는:" + result);
        }

        public int Calc(int height, int bottomLine)
        {
            int result = 0;
            result = (height * bottomLine) / 2;
            return result;
        }
    }
    class Song
    {
        string title;
        string artist;
        string album;
        string composer;
        int year;
        int track;

        public void SetSongInfo()
        {
            Console.WriteLine("타이틀을 입력:");
            this.title = Console.ReadLine();
            Console.WriteLine("아티스트이름을 입력:");
            this.artist = Console.ReadLine();
            Console.WriteLine("앨범을 입력:");
            this.album = Console.ReadLine();
            Console.WriteLine("작곡가를 입력:");
            this.composer = Console.ReadLine();
            Console.WriteLine("작곡년도를 입력:");
            this.year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("트랙번호를 입력:");
            this.track = Int32.Parse(Console.ReadLine());
        }
        public void ShowInfo()
        {
            Console.Clear();
            Console.WriteLine("입력하신 정보\n");
            Console.WriteLine($"타이틀:{title}");
            Console.WriteLine($"아티스트이름:{artist}");
            Console.WriteLine($"앨범이름:{album}");
            Console.WriteLine($"작곡가이름:{composer}");
            Console.WriteLine($"작곡년도:{year}");
            Console.WriteLine($"트랙번호:{track}");
        }
    }


    //3. Rectangle클래스를 작성하세요
    //   int타입의 x1, y1, x2, y2 : 사각형을 구성하는 두 점의 좌표
    //   void set(int x1, int y1, int x2, int y2) : 좌표 설정
    //   int square() : 사각형 넓이 리턴
    //   void show() : 좌표와 넓이 등 직사각형 정보의 화면 출력
    //   bool equals(Rectangle r) : 인자로 전달된 객체 r과 현 객체가 동일한 좌표의 직사각형이면 true 리턴

    class Rectangle
    {
        public int x1 { get; set; }
        public int y1 { get; set; }
        public int x2 { get; set; }
        public int y2 { get; set; }

        public void set(int _x1, int _x2, int _y1, int _y2)
        {
            this.x1 = _x1;
            this.y1 = _y1;
            this.x2 = _x2;
            this.y2 = _y2;
        }

        public int square()
        {
            int square1 = (x1 - x2) * (y1 - y2);
            return square1;
        }

        public void show()
        {
            Console.WriteLine("\nx1의 길이는" + x1);
            Console.WriteLine("x2의 길이는" + x2);
            Console.WriteLine("y1의 길이는" + x1);
            Console.WriteLine("y2의 길이는" + y2);
            Console.WriteLine("사각형의 넓이는" + square());
        }
    }
    class HomeWork1
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }

        static void Main(string[] args)
        {
            Triangle Q1 = new Triangle();
            Song Q2 = new Song();
            Rectangle Q3 = new Rectangle();
            int x1, x2, y1, y2;
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");
                switch (sel)
                {
                    case 1:
                        Q1.Input();
                        break;
                    case 2:
                        Q2.SetSongInfo();
                        Q2.ShowInfo();
                        break;
                    case 3:
                        Get();
                        Q3.set(x1, x2, y1, y2);
                        Q3.show();
                        Console.WriteLine("\n" + equals(Q3));
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
            void Get()
            {
                Console.WriteLine("x1의 값을 입력");
                x1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("x2의 값을 입력");
                x2 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("y1의 값을 입력");
                y1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("y2의 값을 입력");
                y2 = Int32.Parse(Console.ReadLine());
            }
            bool equals(Rectangle Q3)
            {
                if(Q3.x1 == x1 && Q3.x2 == x2 && Q3.y1 == y1 && Q3.y2 == y2)
                return true;
                else 
                return false;
            }
        }
    }
}
