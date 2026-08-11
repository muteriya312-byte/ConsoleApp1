using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class clock
    {
        private int hour;
        private int minute;
        private int second;

        public clock()
        {
            hour = 12;
            minute = 0;
            second = 0;
        }

        public clock(int h , int m ,int s)
        {
            hour =h; minute=m; second = s;
        }

        public void Increment()
        {
            second++;
            if (second == 60)
            {
                second = 0;
                minute++;

                if(minute == 60)
                {
                    minute = 0;
                    hour++;

                    if(hour == 24)
                    {
                        hour = 0;
                    }
                }
            }
        }
        public void Display()
        {
            Console.WriteLine("Time : {0:D2} : {1:D2} : {2:D2}", hour, minute, second);
        }
    }
    class t9
    {
        static void Main(string[] args)
        {
            clock c = new clock(10, 59, 59);

            Console.WriteLine("Current Time");
            c.Display();

            c.Increment();

            Console.WriteLine("After Increment");
            c.Display();

            c.Increment();

            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();
        }
    }
}
