using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial3
{
    internal class Student1
    {
        public int Id;
        public string Name;

        public int id
        {
            get { return Id; }      //get will read value
            set { Id = value; }     //set will read value
        }

        public string name
        {
            get { return Name; }    //get will read value
            set { Name = value; }   //set will read value
        }

        //empty constructor
        public Student1()
        {
            Id = 101;
            Name = "Hiral";
        }

        //parameterized constructor
        public Student1(int i, string n)
        {
            Id = i;
            Name = n;
        }

        //static method
        public void Display()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
        }


    }

    class t4
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1(101, "Mital");
            Student1 s2 = new Student1(102, "Hiral");
            Student1 s3 = new Student1(103, "Sonu");
            Student1 s4 = new Student1(104, "Dhara");
            Student1 s5 = new Student1(105, "Shreeya");
            s1.Display();
            s2.Display();
            s3.Display();
            s4.Display();
            s5.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");
        }
    }
}