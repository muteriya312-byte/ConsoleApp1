using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class class1
    {
        private int enroll;
        private string name;
        private string branch;
        
        public void AcceptData(int e , string n, string b)
        {
            enroll = e;
            name = n;
            branch = b;
        }
        public void Display()
        {
            Console.WriteLine("-----------------------Student Details--------------------");
            Console.WriteLine("Enrollment number is : " + enroll);
            Console.WriteLine("Name is : " + name);
            Console.WriteLine("Branch is : " + branch);
        }
    }

    internal class t1
    {
        static void Main(string[] args)
        {
            class1 std1 = new class1();
            class1 std2 = new class1();

            std1.AcceptData(101, "Mital", "CE");
            Console.WriteLine("student 1 Details");
            std1.Display();

            std2.AcceptData(102, "Hiral", "CE");
            Console.WriteLine("student 2 Details");
            std2.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
