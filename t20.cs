using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //base class
    class Persons
    {
        private int age;
        private string name;

        //this belongs to  the current object/variable
        public Persons(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
        public void Display()
        {
            Console.WriteLine("Age of Person : " + age);
            Console.WriteLine("Name of Person : " + name);
        }
    }
    internal class t20
    {
        public static void Main(string[] args)
        {
            Persons p = new Persons(20, "Mital");
            p.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.Read();
        }
    }
}
