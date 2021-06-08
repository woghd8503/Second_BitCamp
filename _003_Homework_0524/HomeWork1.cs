using System;
using System.Collections.Generic;
using System.Text;

namespace _003_Homework_0524
{
    //1. 5개의 int배열을 선언하고
    //   난수로 값을 입력하고
    //   출력하세요

    //2. 2개의 새로운 int배열을 할당하고
    //   값을 복사하세요

    //3. Arrays.Sort를 사용해서 오름차순 정렬하세요

    //4. 정렬을 하고 내림차순으로 출력하세요
    class HomeWork1
    {
        private static void ClearScreen()
        {
            Console.ReadLine();
            Console.Clear();
        }
        private static void SelectQestion()
        {
            while (true)
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.Write("\n\t문제 번호 입력 (나가기는 0 입력) : ");
                int sel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------------------------------------------------------------");

                if (sel == 0)
                    break;
                switch (sel)
                {
                    case 1:
                        Q1();
                        break;
                    case 2:
                        Q2();
                        break;
                    case 3:
                        Q3();
                        break;
                    case 4:
                        Q4();
                        break;
                    default:
                        Console.WriteLine("잘못 입력하셨습니다.");
                        break;
                }
                ClearScreen();
            }
        }

        private static void Q1()
        {    
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t1. 5개의 int배열을 선언하고 난수로 값을 입력하고 출력");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[5];
            Random r = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                input[i] = r.Next(0, 10);
            }
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                    Console.WriteLine($"\t 5개의 배열에 입력된{i+1}번째 난수는: " + input[i]);
            }
        }
        private static void Q2()
        {    
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t2. 2개의 새로운 int배열을 할당하고 값을 복사하시오");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[5] { 1, 2, 3, 4, 5};
            int[] input1 = new int[5] { 5, 4, 3, 2, 1};

            Array.Copy(input1, 2, input, 3, 2); // 1, 2, 3, 3, 2
            input = (int[])input1.Clone();
            Console.WriteLine("\n[결과 값]\n");
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine($"\t 복사된 배열의 {i + 1}번째 배열값:" + input[i]);
            }
        }
        private static void Q3()
        {   
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t3. Arrays.Sort를 사용해서 오름차순 정렬하세요");
            Console.WriteLine("--------------------------------------------------------------------------------");

            int[] input = new int[5] { 2, 0, 3, 1, 9};

            Array.Sort(input);
            //Array.Reverse(input);
            Console.WriteLine("\n[결과 값]\n");

            foreach (var value in input)
            {
                Console.WriteLine($"배열값: {value}");
            }
        }
        private static void Q4()
        {    
            ClearScreen();
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("\n\t4. 정렬을 하고 내림차순으로 출력하세요");
            Console.WriteLine("--------------------------------------------------------------------------------");
            int[] arr = new int[10] { 4, 3, 2, 5, 11, 3333, 2, 4, 6, 33 };

            Array.Sort(arr);
            Array.Reverse(arr);
            Console.WriteLine("\n[결과 값]\n");

            foreach (var value in arr)
            {
                Console.WriteLine(value);
            }
        }
        static void Main()
        {
            SelectQestion();
        }
    }
}

