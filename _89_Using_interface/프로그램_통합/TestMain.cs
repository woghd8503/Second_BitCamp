using _89_Using_interface.구현클래스;
using _89_Using_interface.테스트_클래스;
using System;
using System.Collections.Generic;
using System.Text;

namespace _89_Using_interface.프로그램_통합
{
    class TestMain
    {
        static void Main(string[] args)
        {
            IMp3[] mp3Arr =
            {
                new SamsungMp3(),
                new LgMp3(),
                new SonyMp3()
            };

            TestMp3 testMp3 = new TestMp3();

            foreach(IMp3 mp3 in mp3Arr)
            {
                testMp3.Mp3 = mp3;
                testMp3.onOffTest();
                testMp3.volumeTest();
                testMp3.playTest();
            }
        }
    }
}
