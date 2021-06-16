using System;

namespace _121_NeedsGeneric
{
    // int를 감싸는 클래스(Wrapper Class)
    class WrapperInt
    {
        private int data;
        public WrapperInt()
        {
            data = 0;
        }
        public WrapperInt(int data)
        {
            this.data = data;
        }
        public int Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public void outValue()
        {
            Console.WriteLine(this.data);
        }
    }
    // double형 변수의 차이만 있고 나머지 구성은 동일한 Wrapper 클래스
    // double을 감싸는 클래스
    class WrapperDouble
    {
        private double data;
        public WrapperDouble()
        {
            data = 0;
        }
        public WrapperDouble(double data)
        {
            this.data = data;
        }
        public double Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public void outValue()
        {
            Console.WriteLine(this.data);
        }
    }
    //WrapperInt와 WrapperDouble과 구조가 동일하고
    //자료형의 차이만 있다.
    //string을 감싸는 클래스
    class WrapperString
    {
        private string data;
        public WrapperString()
        {
            data = null;
        }
        public WrapperString(string data)
        {
            this.data = data;
        }
        public string Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public void outValue()
        {
            Console.WriteLine(this.data);
        }
    }
    class NeedsGenericEx
    {
        static void Main(string[] args)
        {
            WrapperInt wi = new WrapperInt(1234);
            wi.outValue();
            WrapperDouble wd = new WrapperDouble(3.14);
            wd.outValue();
            WrapperString ws = new WrapperString("대한민국");
            ws.outValue();
        }
    }
}