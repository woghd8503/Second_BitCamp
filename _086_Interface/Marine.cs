using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    class Marine : StarUnit
    {
        public override void attack()
        {
            Console.WriteLine("두두두두------");
        }
        public override void move()
        {
            Console.WriteLine("뚜벅뚜벅...");
        }
        public override void die()
        {
            Console.WriteLine("으악");
        }
    }
}
