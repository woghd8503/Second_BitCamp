using System;
using System.Collections.Generic;
using System.Text;

namespace _96_Deligate
{
    delegate void notice(string info);
    class Customer
    {
        private int id;
        public Customer(int id)
        {
            this.id = id;
        }
        public void sendCust(string info)
        {
            Console.WriteLine("{0}번 고객에게 {1}를 전송", id, info);
        }
    }
    class DeligateEx
    {
        static void Main(string[] args)
        {
            Customer[] customerArr = new Customer[10];
            for (int i = 0; i < customerArr.Length; i++)
                customerArr[i] = new Customer(i);

            notice alramCust = null;
            alramCust += customerArr[1].sendCust;
            alramCust += customerArr[3].sendCust;
            alramCust += customerArr[5].sendCust;
            alramCust += customerArr[8].sendCust;

            alramCust("증권 찌라시");
        }
    }
}
