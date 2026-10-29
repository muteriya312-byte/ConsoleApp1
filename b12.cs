using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public int Marks { get; set; }
    }

    class b12
    {
        static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 1, Name = "Rahul", Course = "BCA", Marks = 85 },
                new Student { Id = 2, Name = "Priya", Course = "BCA", Marks = 65 },
                new Student { Id = 3, Name = "Neha", Course = "BCA", Marks = 75 }
            };

            var result = from s in students
                         where s.Marks > 70
                         orderby s.Marks
                         select s;

            Console.WriteLine("Students having marks greater than 70:\n");

            foreach (Student s in result)
            {
                Console.WriteLine(s.Id + "  " + s.Name + "  " + s.Course + "  " + s.Marks);
            }
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}