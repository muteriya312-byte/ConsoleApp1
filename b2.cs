using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    interface IPersonalDetails
        {
            void GetPersonalDetails();
            void ShowPersonalDetails();


        }

        interface IProfessionalDetails
        {
            void GetProfessionalDetails();
            void ShowProfessionalDetails();

        }

        class emp : IPersonalDetails, IProfessionalDetails
        {
            string name;
            string address;
            string gender;

        int no_of_exp;
        double salary;
        string company_name;

            public void GetPersonalDetails()
            {
                Console.WriteLine("Enter Employee Name : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Employee Address : ");
                address = Console.ReadLine();

                Console.WriteLine("Enter Employee Gender : ");
                gender = Console.ReadLine();
            }
            public void ShowPersonalDetails()
            {
                Console.WriteLine("Employee Name : " + name);
                Console.WriteLine("Employee Address : " + address);
                Console.WriteLine("Employee Gender : " + gender);
            }

            public void GetProfessionalDetails()
            {
            Console.WriteLine("Enter number of Years of Experience :");
            no_of_exp = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter salary :");
            salary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter name of the Company :");
            company_name = Console.ReadLine();
            }

            public void ShowProfessionalDetails()
            {
            Console.WriteLine("Number of Years of Experience :" + no_of_exp);
            Console.WriteLine("Salary is :" + salary);
            Console.WriteLine("Company name :" + company_name);
            }

        }
        internal class T6_program2
        {
            public static void Main(string[] args)
            {
            emp e = new emp();
            e.GetPersonalDetails();
            e.ShowPersonalDetails();

            e.GetProfessionalDetails();
            e.ShowProfessionalDetails();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
        }
    }

    