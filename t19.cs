using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Students
    {
        static int count = 0;

        public Students()
        {
            count++;
        }
        public static void Display()
        {
            Console.WriteLine("Total number of Students : " + count);
        }

    }
    internal class t19
    {
        public static void Main(string[] args)
        {
            Students s1 = new Students();
            Students s2 = new Students();
            Students s3 = new Students();
            Students s4 = new Students();
            Students s5 = new Students();

            Students.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.Read();
        }
    }
}
