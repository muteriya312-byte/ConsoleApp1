using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //base classs
    class Person
    {
        public int age { get; set; }
        public string gender { get; set; }

        public void DisplayPersonDetails()
        {
            Console.WriteLine("-------------Person's Details--------------");
            Console.WriteLine("Age of Person: " + age);
            Console.WriteLine("Gender of Person: " + gender);

        }

    }
    //derived class
    class Student : Person
    {
        public int Enroll_no { get; set; }
        public string name {  get; set; }

        public void DisplayStudentDetails()
        {
            Console.WriteLine("-------------Student's Details--------------");
            Console.WriteLine("Enrollment number of Student :" + Enroll_no);
            Console.WriteLine("Name od Student :" + name);

        }
    }
    internal class t15
    {
        static void Main(string[] args)
        {
            Student s = new Student();

            Console.WriteLine("Eneter Person's Age :");
            s.age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr Person Gender : ");
            s.gender = Console.ReadLine();

            Console.WriteLine("Enetr Student's Enrollment number : ");
            s.Enroll_no = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr Student's Name : ");
            s.name = Console.ReadLine();

            s.DisplayPersonDetails();
            s.DisplayStudentDetails();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");

            Console.ReadLine();
        }
    }
}
