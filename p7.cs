using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p7
    {
        static void Main(string[] args)
        {
            int number, i, result;
            Console.WriteLine("Enter a number for Table : ");
            number = Convert.ToInt32(Console.ReadLine());

            i = 1;
            while(i<=10)
            {
                result = number * i;
                Console.WriteLine(number + " X " + i + " = " + result);
                i++;

            }
            Console.Read();
        }
    }
}
