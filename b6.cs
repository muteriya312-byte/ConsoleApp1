using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class b6
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a second number : ");
                int b = Convert.ToInt32(Console.ReadLine());

                int result = a / b;
                Console.WriteLine("Result : "+result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error : Cannot divide by zero. ", ex.Message);
            }


            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
