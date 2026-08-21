using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee
    {
        private double salary;
        public void SetSalary(double amount)
        {
            salary = amount;
        }
        public double GetSalary()
        {
            return salary;
        }
    }
    class t14
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.WriteLine("Enter Employee's Salary :");
            double amount=Convert.ToDouble(Console.ReadLine());

            emp.SetSalary(amount);
            Console.WriteLine("Employee's Salary is "+emp.GetSalary());

            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();
        }

    }
    
}
