using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employees
    {
        protected string designation;
        protected double salary;

        public Employees(string designation, double salary)
        {
            this.designation = designation;
            this.salary = salary;
        }
    }
    class Department1 : Employees
    {
        private string dept_name;

        public Department1(string designation, double salary, string dept_name) : base(designation, salary)
        {
            this.dept_name = dept_name;
        }
        public void Display()
        {
            Console.WriteLine("Designation of the Employee :"+ designation);
            Console.WriteLine("Salary of the Employee :"+ salary);
            Console.WriteLine("Department name of the Employee : "+dept_name);
        }
    }
    internal class t21
    {
        public static void Main(string[] args)
        {
            Department1 d = new Department1 ("Software Engineer",50000,"Moblie Application Devloper");
            d.Display();
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.Read();
        }

    
    }
}
