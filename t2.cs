using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class class2
    {
        private int hour;
        private int min;
        private int sec;

        //No Argument Constructor
        public class2()
        {
            hour = 12;
            min = 0;
            sec = 0;
        }

        //parameterized Constructor
        public class2(int h, int m, int s)
        {
            hour = h;
            min = m;
            sec = s;
        }

        public void IncrementTime() 
        {
            sec++;

            if (sec == 60)
            {
                sec = 0;
                min++;

                if (min == 60)
                {
                    min = 0;
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
            Console.WriteLine("{0:D2} : {1:D2} : {2:D2}", hour, min, sec);
        }
        public int GetHour() 
        {
            return hour;
        }

        public int GetMinute()
        {
            return min;
        }

        public int GetSecond()
        {
            return sec;
        }
    }

    class t2
    {
        static void Main(string[] args)
        {
            class2 c = new class2();

            Console.WriteLine("Current Time");
            c.Display();

            c.IncrementTime();

            Console.WriteLine("After Incement");
            c.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
