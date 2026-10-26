using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class b10
    {
        public static void Main(string[] args)
        {

            List<int> numbers = new List<int>() 
            { 
                49,67,45,82,35,91,55
            };
            Console.WriteLine("Marks greater than 50: ");

            numbers.FindAll(x => x > 50).ForEach(x => Console.WriteLine(x));

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
