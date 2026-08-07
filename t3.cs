using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_tutorial3
{
    internal class StudentInfo
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
        public StudentInfo()
        {
            Id = 101;
            Name = "Hiral";
        }

        //parameterized constructor
        public StudentInfo(int i, string n)
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

    class t3
    {
        static void Main(string[] args)
        {
            StudentInfo s = new StudentInfo(101, "Mital");
            s.Display();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");
        }
    }
}