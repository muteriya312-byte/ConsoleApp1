using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StudentDetails
    {
        private int enroll;
        private string name;

        public int e
        {
            get { return enroll; }
            set { enroll = value; }
        }
        public string Name
        {
            get { return name; }
            set {  name = value; }
        }

        public StudentDetails()
        {

        }
        public StudentDetails(int eno,string no)
        {
            enroll = eno;
            Name = no;
        }
        public void Display()
        {
            Console.WriteLine("Enrollment Number : " + enroll);
            Console.WriteLine("Name : " + Name);
        }

    }
    class t7
    {
        static void Main(string[] args)
        {
           StudentDetails student = new StudentDetails();

            Console.WriteLine("Enter enrollment number : ");
            student.e = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Name :");
            student.Name = Console.ReadLine();

            student.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");
        }
    }
}
