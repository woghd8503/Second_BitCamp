using System;
using System.Threading;

namespace _113_ParamThread
{
    class Program
    {
        //ParameterizedThreadStart를 쓰면 스레드에 매개변수를
        //전달할 수 있다.
        //모든 자료형을 전달하기 위해 object로 전달하고
        //사용할 때는 형변환해서 사용하면 된다.
        static void threadProc(object count)
        {
            for(int i = 0; i<(int)count; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine("Worker Thread End~");
        }
        static void Main(string[] args)
        {
            Thread thread = new Thread(new ParameterizedThreadStart(threadProc));
            //스레드의 매개변수에 10을 전달한다
            thread.Start(7);

            Console.WriteLine("Wait Main Thread...");
            thread.Join();
            Console.WriteLine("Main Thread End~");
        }
    }
}
