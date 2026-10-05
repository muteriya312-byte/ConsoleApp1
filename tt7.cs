using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee11
    {
        // Virtual method
        public virtual void CalculateSalary()
        {
            Console.WriteLine("Employee Salary");
        }
    }

    class Manager : Employee11
    {
        // Override method
        public override void CalculateSalary()
        {
            int salary = 60000;
            Console.WriteLine("Manager Salary = " + salary);
        }
    }

    class Developer : Employee11
    {
        // Override method
        public override void CalculateSalary()
        {
            int salary = 45000;
            Console.WriteLine("Developer Salary = " + salary);
        }
    }

    class tt7
    {
        static void Main(string[] args)
        {
            Employee11 e;

            e = new Manager();
            e.CalculateSalary();

            e = new Developer();
            e.CalculateSalary();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }
}
