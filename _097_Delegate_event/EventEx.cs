using System;
using System.Collections.Generic;
using System.Text;

namespace _97_Delegate_event
{
    delegate void notice();

    class Message
    {
        public void sendComplete()
        {
            Console.WriteLine("모두 전송했습니다");
        }
    }
    class Sender
    {
        Random rand = new Random();
        //delegate의 앞에 event를 붙이는 것과
        //관계없이 동작은 동일하다.
        //그런데 event를 붙이면 외부 클래스에서
        //delegate를 통해 정보를 엿볼 수 없다.
        //public  notice OnComplete;
        // 1) 불필요한 정보 노출 방지(보안)
        // 2) 멀티스레드 안정성을 확보

        // public notice OnComplete;
        public notice OnComplete;
        public void send()
        {
            for (int i = 0; i < 100; i += 10)
            {
                Console.WriteLine(i + "% 전송중");
                System.Threading.Thread.Sleep(100 + rand.Next(1000)); //100 ~ 1099초
            }
            // 등록한 이벤트 메서드가 존재한다면
            if (OnComplete != null)
                OnComplete();
        }
    }
    class EventEx
    {
        static void Main(string[] args)
        {
            //s객체가 전송을 완료하면
            //m객체의 sendComplete를 호출하겠다
            //(s객체는 전송완료 이벤트를 m객체에 통보)
            Message m = new Message();
            Sender s = new Sender();
            s.OnComplete += m.sendComplete;
            s.send();
        }
    }
}
