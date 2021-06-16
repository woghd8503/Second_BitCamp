using System;

namespace _122_GenericEx
{
    //자료형만 다르고 구조가 동일하다면
    //1번만 코딩해서 각각 다른 자료형에 사용되게 하도록
    //탄생한 문법이 Generic이다.
    //(C++에서는 Template이라 불린다.)
    //; Generic이 주로 사용되는 분야는
    // 자료구조와 알고리즘 구현 분야이다.
    // 자료구조 : 데이터의 저장 구조가 중요
    // 알고리즘 : 문제의 해결 방식이 중요
    //T는 Type의 약자이다. 즉 아무 자료형이나 올 수 있다라는
    //    뜻이다.
    //    T대신 다른 글자를 쓰거나 단어를 써도 무방하다.
    //    그러나 Type이 1개일 때는 T로 쓰는 경우가 많다.
    //    <T>라 쓰여 있으면 아무 타입이나 가능한
    //    Generic이라고 생각하면 된다.
    class Wrapper<T>
    {
        private T data;
        public Wrapper()
        {
            //int는 0, double은 0.0
            //string은 null,
            //다른 class도 null로 초기화

            data = default(T);
        }
        public Wrapper(T data)
        {
            this.data = data;
        }
        public T Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
        public void outValue()
        {
            Console.WriteLine(this.data);
        }
    }
    class GenericEx
    {
        static void Main(string[] args)
        {
            Wrapper<int> wi = new Wrapper<int>(1234);
            wi.outValue();

            Wrapper<double> wd = new Wrapper<double>(3.14);
            wi.outValue();

            Wrapper<string> ws = new Wrapper<string>("대한민국");
            wi.outValue();
        }
    }
}
