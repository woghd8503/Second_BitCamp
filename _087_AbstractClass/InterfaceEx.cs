using System;
using System.Collections.Generic;
using System.Text;

namespace _86_Interface
{
    class InterfaceEx
    {
        static void unitTest(StarUnit sUnit, int count)
        {
            for(int i = 0; i< count; i++)
            {
                Console.Write("======{0}회======", i + 1);
                sUnit.attack();
                sUnit.move();
                sUnit.die();
                System.Threading.Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            StarUnit[] sUnitArr = { new Marine(), new Hydra(), new Scv() };
            foreach (StarUnit sUnit in sUnitArr)
                unitTest(sUnit, 3);
        }
    }
}
