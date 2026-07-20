using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p15
    {
        static void Main(string[] args)
        {
            int number, original, remainder, result = 0;
            Console.WriteLine("Enter a number to calculate Armstrong number: ");
            number = Convert.ToInt32(Console.ReadLine());

            original = number;
            while(number > 0)
            {
                remainder = number % 10;
                result = result + (remainder * remainder * remainder);
                number = number / 10;

            }
            if (original == result)
            {
                Console.WriteLine("This is Armstrong number");
            }
            else
            {
                Console.WriteLine("This is not Armstrong number");
            }
            Console.WriteLine();
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. :  24SOECE11043");
            Console.ReadLine();
        }
    }
}
