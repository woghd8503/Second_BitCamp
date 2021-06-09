using System;
using System.Threading;

namespace _106_Thread_IsAlive_Sync
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

            //3번재 동기화 방법
            // thread객체와 연결된 스레드가 살아있는지 여부 확인
            // 이런 방법도 있다~
            //

            while(thread.IsAlive)
            {
                Console.WriteLine("Worker Thread Running...");
                Thread.Sleep(10);
            }

            Console.WriteLine("1 ~ 100까지 짝수합: " + sumEven);
            Console.WriteLine("1 ~ 100까지 홀수합: " + sumOdd);
            Console.WriteLine("1 ~ 100 총합 : " + (sumEven + sumOdd));
            Console.WriteLine("Main Thread End~");
        }
    }
}
