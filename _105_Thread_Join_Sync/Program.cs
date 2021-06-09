using System;
using System.Threading;

namespace _105_Thread_Join_Sync
{
    class Program
    {
        static int sumOdd = 0; //   홀수 합
        static int sumEven = 0; //  짝수 합
        // 1 ~ 100까지 홀수합을 구하는 메서드(일)
        static void threadProc()
        {
            for (int i = 1; i <= 100; i += 2)
            {
                sumOdd += i;
                Console.WriteLine("Worker Thread : " + i);
                Thread.Sleep(100);
            }
            Console.WriteLine("Worker Thread End ~");
        }
        static void Main(string[] args)
        {
            // 홀수합을 맡기기 위한 스레드 요청(직원 고용)
            Thread thread = new Thread(new ThreadStart(threadProc));
            thread.Start();  // 직원 일 시작
            for (int i = 0; i <= 100; i += 2)
            {
                sumEven += i;
                Console.WriteLine("Main thread : " + i);
                Thread.Sleep(50);
            }

            // Main thread는 3000ms 동안 스케줄링을
            // 부여받지 않는다

            //2번재 동기화 방법
            //Join메서드는 해당 스레드가 동작중에는 멈춰있다가
            //해당 스레드가 종료되면 바로 리턴하는 메서드 
            //Worker Thread가 실행하는 threadProc메서드가
            //리턴하면(종료하면) CLR에 종료 신호가 전달된다
            //CLR은 해당 종료 신호가 발생하면 thread 객체의
            //Join을 리턴하게 된다.
            //장점: Sleep처럼 무조건 기다릴 필요 없다

            thread.Join(); // Main Thread 중지

            Console.WriteLine("1 ~ 100까지 짝수합: " + sumEven);
            Console.WriteLine("1 ~ 100까지 홀수합: " + sumOdd);
            Console.WriteLine("1 ~ 100 총합 : " + (sumEven + sumOdd));
            Console.WriteLine("Main Thread End~");
        }
    }
}
