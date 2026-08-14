using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class EmployeeDetails
    {
        private int empid;
        private string empName;
        private double basicSalary;
        private double netSalary;

        public EmployeeDetails(int id, string name, double salary)
        {
            empid = id;
            empName = name;
            basicSalary = salary;
        }
        public void CalculateSalary()
        {
            double hra = basicSalary * 0.20;
            double da = basicSalary * 0.10;
            netSalary = basicSalary + hra + da;
        }
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("-----------Employee Details--------------");
            Console.WriteLine("Employee id is :" + empid);
            Console.WriteLine("Employee name is :" + empName);
            Console.WriteLine("Employee basic Salary is :" + basicSalary);
            Console.WriteLine("Calculated net Salary is :" + netSalary);

        }
    }

    class t10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee Id ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter basic Salary :");
            double salary = Convert.ToDouble(Console.ReadLine());

            EmployeeDetails emp= new EmployeeDetails(id, name, salary);
            emp.CalculateSalary();
            emp.DisplayEmployeeDetails();

            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();

        }
    }
}
