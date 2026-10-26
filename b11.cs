using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class b11
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>()
            {
                49,67,45,82,35,91,55,12,34,56
            };
            
            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              orderby n
                              select n;

            Console.WriteLine("Even Numbers : ");

            foreach (int n in evenNumbers)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
