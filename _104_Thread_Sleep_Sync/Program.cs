using System;
using System.Threading;

//Main thread : 1 ~ 100까지 짝수의 합
//Worker thread : 1 ~ 100까지 홀수의 합

//Main thread에서 : 두 합을 더해서 출력
// *필요 기능
// Main thread에서 Worker thread의 동작을
// 대기하고 있다가 끝나면 결과를 합산

namespace _104_Thread_Sleep_Sync
{
    class Program
    {
        static int sumOdd = 0; //   홀수 합
        static int sumEven = 0; //  짝수 합
        // 1 ~ 100까지 홀수합을 구하는 메서드(일)
        static void threadProc()
        {
            for(int i = 1; i <= 100; i += 2)
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
            for(int i = 0; i <= 100; i += 2)
            {
                sumEven += i;
                Console.WriteLine("Main thread : " + i);
                Thread.Sleep(50);
            }

            //1번째 동기화 방법
            //Sleep을 사용하면 해당 시간동안 스레드는
            //멈춰있다(스케중링에서 벗어나 있다)
            //    1-1) 장점: 쉽다
            //    1-2) 단점: 시간의 차이(낭비)기 있을 수 있다

            // Main thread는 3000ms 동안 스케줄링을
            // 부여받지 않는다
            Thread.Sleep(3000); // Main Thread 중지

            Console.WriteLine("1 ~ 100까지 짝수합: " + sumEven);
            Console.WriteLine("1 ~ 100까지 홀수합: " + sumOdd);
            Console.WriteLine("1 ~ 100 총합 : " + (sumEven + sumOdd));
            Console.WriteLine("Main Thread End~");
        }
    }
}
