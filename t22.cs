using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee3 
    { 
        public  void EmpStatus()
        {
            Console.WriteLine("Employe is Working");
        }
    }
    class Department : Employee3
    {
        public new void EmpStatus()
        {
            Console.WriteLine("Employee is NOT working");
        }
    }
    internal class t22
    { 
        public static void Main(string[] args)
        {
            Department d = new Department();
            d.EmpStatus();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.Read();
        }
    }
}
