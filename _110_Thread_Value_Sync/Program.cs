using System;
using System.Threading;

//동기화
//    1) 스레드간의 시간차를 조절
//    2) 스레드간에 공유하는 변수의 값의 정확도를 보장

//1개 스레드는 100000번 1씩 증가
//1개 스레드는 100000번 1씩 감소
//결과는 0이어야 할 것 같은데
//할 때마다 예측할 수 없는 값이 나온다.
//예상값과 차이가 있다
//(값의) 동기화의 오류
namespace _109_Thread_value_Sync_Error
{
    class Program
    {
        // 화장실 잠금장치와 같은
        // 스레드가 동시에 진입하지 못하게 만드는 잠금 obj
        static object keyObj = new object();
        static int cnt = 0;
        static void threadPlus()
        {
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
                lock(keyObj)
                {
                    cnt++;
                }
            }
        }
        static void threadMinus()
        {
            for (int i = 0; i < 100000; i++)
            {
                lock (keyObj)
                {
                    cnt--;
                }
            }
        }
        static void Main(string[] args)
        {
            Thread tPlus = new Thread(new ThreadStart(threadPlus));
            Thread tMinus = new Thread(new ThreadStart(threadMinus));
            tPlus.Start();
            tMinus.Start();

            tPlus.Join();
            tMinus.Join();

            Console.WriteLine("cnt = " + cnt);
        }
    }
}
