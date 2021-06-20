using _61_AddressClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _98_polymorphism_Address
{
    class UnivAddress : Address
    {
        public string Major { get; set; }
        public string Year { get; set; }

        public override void showInfo(int order)
        {
            base.showInfo(order);
            Console.WriteLine("전공 : " + this.Major);
            Console.WriteLine("학년 : " + this.Year);
        }
        public override void showInfo()
        {
            base.showInfo();
            Console.WriteLine("전공 : " + this.Major);
            Console.WriteLine("학년 : " + this.Year);
        }
    }
}
