using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Sealed class
    sealed class StudentResult
    {
        private int rollNo;
        private string name;
        private int marks;

        // Constructor
        public StudentResult(int rollNo, string name, int marks)
        {
            this.rollNo = rollNo;
            this.name = name;
            this.marks = marks;
        }

        // Display result
        public void DisplayResult()
        {
            Console.WriteLine("Student Result");
            Console.WriteLine("----------------");
            Console.WriteLine("Roll No : " + rollNo);
            Console.WriteLine("Name    : " + name);
            Console.WriteLine("Marks   : " + marks);

            if (marks >= 35)
            {
                Console.WriteLine("Result  : PASS");
            }
            else
            {
                Console.WriteLine("Result  : FAIL");
            }
        }
    }
    class t24_2
    {
        public static void Main(String[] args)
        {
            // Creating object of sealed class
            StudentResult s = new StudentResult(101, "Mital", 78);

            s.DisplayResult();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");

            Console.ReadKey();
        }
    }
}


