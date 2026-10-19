using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    delegate void StudentDetails();
    internal class b4
    {
       static void DisplayName()
        {
            Console.WriteLine("Student Name: Mital");
        }
        static void DiaplayCourse()
        {
            Console.WriteLine("Course :  B.Tech");
        }
        static void DiaplySemester()
        {
            Console.WriteLine("Semester : 5th");
        }
        public static void Main(string[] args) 
        {
            StudentDetails sd;

            sd = DisplayName;
            sd += DiaplayCourse;
            sd += DiaplySemester;

            Console.WriteLine("Student Details : ");
            sd();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
