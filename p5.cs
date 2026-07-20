using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p5
    {
       public static void Main(string[] args)
        {
            int number, i, fact = 1;
            Console.WriteLine("Enter an input for fact number : ");

            number = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + number + ":" + fact);
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. :  24SOECE11043");
            Console.ReadLine();
        }
    }
}
