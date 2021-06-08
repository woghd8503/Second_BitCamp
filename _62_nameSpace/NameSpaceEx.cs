using System;

namespace A
{
    class MyClass
{
    public int i = 10;
}
}

namespace B
{
    class MyClass
    {
        public int i = 20;
    }
}
namespace namespaceEX
{
    class NamespaceEx
    {
        static void Main(string[] args)
        {
            A.MyClass objA = new A.MyClass();
            B.MyClass objB = new B.MyClass();
            Console.WriteLine(objA);
            Console.WriteLine(objB);
            Console.WriteLine(objA.i);
            Console.WriteLine(objB.i);
        }
    }
}