using System;
using System.Threading;

namespace _112_Thread_Value_Monitor_Sync
{
    class Program
    {
        // 화장실 잠금장치와 같은
        // 스레드가 동시에 진입하지 못하게 만드는 잠금 obj
        static object keyObj = new object();
        static int cnt = 0;
        static void threadPlus()
        {
            // 임계영역 진입
            Monitor.Enter(keyObj);
            for (int i = 0; i < 100000; i++)
            {
                // 임계영역(Critical Section)
                // 는 잠금장치가 필요하다
                // lock을 걸면 1개 스레드만 진입 가능
                // 먼저 진입한 스레드가 lock을 건다
                // lock을 탈출 할 대 잠금이 풀리고
                // 다른 스레드가 진입하고 잠근다.

                // lock에 진입한 스레드는
                // Context Switching이 일어나지 않으므로
                // lock내의 연산이 온전히 이루어진다.

                // 단점 : 값의 정확성을 보장
                // 장점 : 여러 개 스레드가 동시에 동작하지 
                //        못하고 대기하므로 속도 자하 현상이 나타난다

                cnt++;
            }
            //입계영역 탈출
            Monitor.Exit(keyObj);
        }
        static void threadMinus()
        {
            // 임계영역 진입
            Monitor.Enter(keyObj);
            for (int i = 0; i < 100000; i++)
            {
                    cnt--;
            }
            //입계영역 탈출
            Monitor.Exit(keyObj);
        }
        static void Main(string[] args)
        {
            Thread[] tThreadArr = new Thread[10];
            tThreadArr[0] = new Thread(new ThreadStart(threadPlus));
            tThreadArr[1] = new Thread(new ThreadStart(threadPlus));
            tThreadArr[2] = new Thread(new ThreadStart(threadPlus));
            tThreadArr[3] = new Thread(new ThreadStart(threadPlus));
            tThreadArr[4] = new Thread(new ThreadStart(threadPlus));

            tThreadArr[5] = new Thread(new ThreadStart(threadMinus));
            tThreadArr[6] = new Thread(new ThreadStart(threadMinus));
            tThreadArr[7] = new Thread(new ThreadStart(threadMinus));
            tThreadArr[8] = new Thread(new ThreadStart(threadMinus));
            tThreadArr[9] = new Thread(new ThreadStart(threadMinus));

            foreach (Thread t in tThreadArr)
                t.Start();
            foreach(Thread t in tThreadArr)
                t.Join();

            Console.WriteLine("cnt = " + cnt);
        }
    }
}
