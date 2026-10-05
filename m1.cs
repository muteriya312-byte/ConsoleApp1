using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employeess
    {
        private int emp_code;
        private string emp_name;
        private string designation;
        private double basicPay;

        public Employeess(int emp_code,string emp_name , string designation, double basicPay)
        {
            this.emp_code = emp_code;
            this.emp_name = emp_name;
            this.designation = designation;
            this.basicPay = basicPay;
        }
        public void CalculatePay()
        {
            double hra = 0.10 * basicPay;
            double da= 0.45 * basicPay;
            double netSalary = basicPay + hra + da;

            Console.WriteLine("EMployee Code :" + emp_code);
            Console.WriteLine("Employee Name :" + emp_name);
            Console.WriteLine("Employee Designation :" + designation);
            Console.WriteLine("Employee Basic Salary :"+ basicPay);
            Console.WriteLine("Employee Net Salary :" + netSalary);
        }
    }
    internal class m1
    {
        public static void Main(string[] args)
        {
            Employeess e1 = new Employeess(101, "Mital", "Frontend Developer", 50000);
            e1.CalculatePay();

            Employeess e2 = new Employeess(102, "Hiral", "Backend Developer", 60000);
            e2.CalculatePay();

            Employeess e3 = new Employeess(103, "Jaldhara", "Python Developer", 40000);
            e3.CalculatePay();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");

            Console.ReadLine();
        }
    }
}
