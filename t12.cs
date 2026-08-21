using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class studentDetils
    {
        public int enroll_no {  get; set; }

        public string name { get; set; }
    }
    class t12
    {
        public static void Main(string[] args)
        {
            studentDetils studentDetils = new studentDetils();

            Console.WriteLine("Enter Enrollment Number: ");
            studentDetils.enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Name :");
            studentDetils.name = Console.ReadLine();

            Console.WriteLine("---------Student Details ---------------");
            Console.WriteLine("Enrollment No is :"+ studentDetils.enroll_no);
            Console.WriteLine("Name is :"+studentDetils.name);

            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();

        }
    }
}
