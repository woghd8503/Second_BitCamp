using System;
using System.Collections.Generic;
using System.Text;

namespace _89_Using_interface.구현클래스
{
    class LgMp3 : IMp3
    {
        public void play()
        {
            Console.WriteLine("LG-Smooth Play~");
        }

        public void turnOff()
        {
            Console.WriteLine("LG-Smooth Off~");
        }

        public void turnOn()
        {
            Console.WriteLine("LG-Smooth On~");
        }

        public void volumeUp()
        {
            Console.WriteLine("LG-Smooth Up~");
        }

        public void volumeDown()
        {
            Console.WriteLine("LG-Well Down~");
        }
    }
}