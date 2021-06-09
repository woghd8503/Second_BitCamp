using System;
using System.Threading;

//이 프로그램을 그냥 실행하면
//Main메서드를 실행하기 위해
//Main Thread가 Main메서드를 순차적으로 진행시킨다

//Thread는 메서드에 기록한 순서대로 일을 진행시키는
//OS/CLR의 리소스 
//Thread?
//프로그래밍을 실행시키는 주체
//thread는 프로그램에서 일하는 존재
//=> 그러므로 일을 부여해야 한다
//    (일 = Method)
//    스레드는 Method를 동작시킨다

//    Main Thread는 Main메서드를 동작시킨다

//    프로그램 상에서도 일이 많아지면 스레드 생성을 요청한다
//    해당 스레드에 일을 시켜야 한다
//    즉, Method를 배정해야 한다

//Main Thread : 나(주인 아저씨)
//Sub(worker) Thread : 직원/알바생
//스레드 생성 요청 : 직원 고용

namespace _103_NoParamThread
{
    class Program
    {
        // 작업 스레드(알바생)를 생성 요청해서
        // 아래 일을 부여하겠다.
        static void threadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Worker Thread : " + i);
                System.Threading.Thread.Sleep(500);
            }
            Console.WriteLine("Worker Thread End");
        }
        static void Main(string[] args)
        {
            // 작업스레드 생성 요청
            // 객체 = 스레드는 아니다
            // 다만 객체가 스레드와 연결되었다.
            // thread객체는 threadProc를 수행한다

            Thread thread = new Thread(new ThreadStart(threadProc));
            thread.Start(); // 실행
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main Thread : " + i);
                System.Threading.Thread.Sleep(300);
            }
            Console.WriteLine("Main Thread End");
        }
    }
}
