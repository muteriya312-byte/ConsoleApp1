using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class b7
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number : ");
                int a = Convert.ToInt32(Console.ReadLine());
               
            }
           
            catch (FormatException ex)
            {
                Console.WriteLine("Error :  " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Format Exception implemented.");
            }
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
