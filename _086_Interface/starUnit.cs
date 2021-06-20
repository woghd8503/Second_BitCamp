using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    class StarUnit
    {
        public virtual void attack()
        {
            Console.WriteLine("공격한다");
        }
        public virtual void move()
        {
            Console.WriteLine("이동한다");
        }
        public virtual void die()
        {
            Console.WriteLine("소멸된다");
        }
    }
}
