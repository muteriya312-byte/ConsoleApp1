using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    sealed class University
    {
        private string school_name;
        private string departrment_name;

        public University(string school_name , string departrment_name)
        {
            this.school_name = school_name;
            this.departrment_name = departrment_name;
        }
        public void Display()
        {
            Console.WriteLine("School Name :" + school_name);
            Console.WriteLine("Department name : "+ departrment_name);
        }
    }
   
    internal class t24
    {
        public static void Main(string[] args)
        {
            University u = new University("School of Engineering" , "Computer Science");
            u.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
        }
    }
}
