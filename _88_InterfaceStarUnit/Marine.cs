using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    class Marine : StarUnit
    {
        public void attack()
        {
            Console.WriteLine("두두두두------");
        }
        public void move()
        {
            Console.WriteLine("뚜벅뚜벅...");
        }
        public void die()
        {
            Console.WriteLine("으악");
        }
    }
}
