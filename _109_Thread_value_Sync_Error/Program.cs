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
        static int cnt = 0;
        static void threadPlus()
        {
            for (int i = 0; i < 100000; i++)
            {
                //임계영역(위험한 지역)
                //Critical Section
                // => 동기화 작업이 필요
                cnt++; // cnt = cnt + 1;
            }
        }
        static void threadMinus()
        {
            for (int i = 0; i < 100000; i++)
                cnt--;
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
