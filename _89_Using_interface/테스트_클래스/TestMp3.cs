using System;
using System.Collections.Generic;
using System.Text;

namespace _89_Using_interface.테스트_클래스
{
    class TestMp3
    {
        public IMp3 Mp3 { get; set; }

        // [디폴트 매개변수]
        // 미리 기본값을 줘서, 메서드 호출시 따로 값을 주지 않으면
        // 자동으로 기본값으로 매개변수에 전달
        private void endTest(bool isDelay = true, int delayTime = 100)
        {
            Console.WriteLine("=====================");
            if(isDelay)
            System.Threading.Thread.Sleep(delayTime);
        }
        public void onOffTest(int count = 3)
        {
            if (this.Mp3 == null) return; // 메서드 종료
            for(int i = 0; i < count; i++)
            {
                Mp3.turnOn();
                Mp3.turnOff();
                endTest();
            }
        }

        public void volumeTest(int count = 3)
        {
            if (this.Mp3 == null) return; // 메서드 종료

            for (int i = 0; i < count; i++)
            {
                Mp3.volumeUp();
                Mp3.play ();
                Mp3.volumeDown();
                Mp3.play();
                endTest();
            }
        }
        public void playTest(int count = 3)
        {
            if (this.Mp3 == null) return; // 메서드 종료

            for (int i = 0; i < count; i++)
            {
                Mp3.turnOn();
                Mp3.volumeUp();
                Mp3.play();
                Mp3.volumeDown();
                Mp3.play();
                Mp3.turnOff();
                endTest();
            }
        }
    }
}
