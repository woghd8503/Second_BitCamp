using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _89_Using_interface.구현클래스
{
    class SonyMp3 : IMp3
    {
        public void play()
        {
            Console.WriteLine("sony - 아베+트럼프 랩을 한다~");
        }

        public void turnOff()
        {
            Console.WriteLine("sony - 아베+트럼프 지지직~");
        }

        public void turnOn()
        {
            Console.WriteLine("sony - 아베+트럼프 쿵~");
        }

        public void volumeDown()
        {
            Console.WriteLine("sony - 아베+트럼프 조용해~");
        }

        public void volumeUp()
        {
            Console.WriteLine("sony - 아베+트럼프 소리질러~");
        }
    }
}
