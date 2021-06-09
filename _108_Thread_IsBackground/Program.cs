using System;
using System.Threading;

namespace _108_Thread_IsBackground
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
            Console.WriteLine("1 ~ 100까지 홀수합: " + sumOdd);
            Console.WriteLine("Worker Thread End ~");
        }
        static void Main(string[] args)
        {
            // 홀수합을 맡기기 위한 스레드 요청(직원 고용)
            Thread thread = new Thread(new ThreadStart(threadProc));
          /*IsBackground 프로퍼티의 default값은 false이다
            true면 Main thread에 종속적이 되어서
                   Main thread가 종료되면 자동적으로 종료
            false면 Main thread에 비종속적이 되어서
                    Main thread의 종료와 무관하게 된다*/

            //주인이 퇴근하자마자 하던 일 멈추고 바로 퇴근
            thread.IsBackground = true;
            thread.Start();  // 직원 일 시작

            for (int i = 0; i <= 100; i += 2)
            {
                sumEven += i;
                Console.WriteLine("Main thread : " + i);
                Thread.Sleep(50);
            }

            // Main thread는 3000ms 동안 스케줄링을
            // 부여받지 않는다

            Console.WriteLine("1 ~ 100까지 짝수합: " + sumEven);
            Console.WriteLine("1 ~ 100 총합 : " + (sumEven + sumOdd));
            Console.WriteLine("Main Thread End~");
        }
    }
}
