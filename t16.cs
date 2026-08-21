using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employees1
    {
        public int EmployeeID { get; set; }
        public string Name {  get; set; }
        public double BasicSalary {  get; set; }

        
    }
    class PermanentEmployee : Employees1
    {
        public void CalculateSalary()
        {
            double hra = BasicSalary * 0.20;
            double da = BasicSalary * 0.10;
            double netSalary = BasicSalary + hra + da;

            Console.WriteLine("Permanent Employee");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Employee ID :" + EmployeeID);
            Console.WriteLine("Name : "+Name);
            Console.WriteLine("Basic Salary :" + BasicSalary);
            Console.WriteLine("HRA :" + hra);
            Console.WriteLine("DA :" + da);
            Console.WriteLine("Net Salary :" + netSalary);
        }
    }
    class ConstractEmployee : Employees1
    {
        public void CalculateSalary()
        {
            double netSalary = BasicSalary;

            Console.WriteLine("Constract Employee");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Employee ID :" + EmployeeID);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Salary :" + netSalary);

        }
    }
    internal class t16
    {
        static void Main(string[] args)
        {
            PermanentEmployee p = new PermanentEmployee();

            p.EmployeeID = 101;
            p.Name = "Mital";
            p.BasicSalary = 30000;
            p.CalculateSalary();

            ConstractEmployee c = new ConstractEmployee();

            c.EmployeeID = 102;
            c.Name = "Hiral";
            c.BasicSalary = 25000;
            c.CalculateSalary() ;

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");   

            Console.ReadLine();
        }
    }
}
