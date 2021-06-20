using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65_getter_setter
{
    class Time
    {
        private int hour;

        public int getHour()    // getter
        {
            return this.hour;
        }
        public void setHour(int hour)   // setter
        {
            if(hour < 24)
                this.hour = hour;
        }

        public void outTime()
        {
            Console.WriteLine("현재 시간은 {0}시입니다", hour);
        }
    }
    class GetSetEx
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            time.setHour(12);
            time.outTime();

            time.setHour(79);
            time.outTime();
        }
    }
}
