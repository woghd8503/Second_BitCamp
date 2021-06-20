using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    class Hydra : StarUnit
    {
        public override void attack()
        {
            Console.WriteLine("퉷~뛔앳");
        }
        public override void move()
        {
            Console.WriteLine("질질");
        }
        public override void die()
        {
            Console.WriteLine("크허헉~");
        }
    }
}
