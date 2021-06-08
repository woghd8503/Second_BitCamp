using System;
using System.Collections.Generic;
using System.Text;

namespace _89_Using_interface.구현클래스
{
    class SamsungMp3 : IMp3
    {
        public void play()
        {
            Console.WriteLine("samsung-Well Play~");
        }

        public void turnOff()
        {
            Console.WriteLine("samsung-Well Off~");
        }

        public void turnOn()
        {
            Console.WriteLine("samsung-Well On~");
        }

        public void volumeUp()
        {
            Console.WriteLine("samsung-Well Up~");
        }

        public void volumeDown()
        {
            Console.WriteLine("samsung-Well Down~");
        }
    }
}
