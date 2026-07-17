using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p11
    {
        static void Main(string[] args)
        {
            String name;
            char gender;
            Console.WriteLine("Enter a name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter gender (F/M) : ");
            gender = Convert.ToChar(Console.ReadLine());

            if(gender=='M' || gender == 'm')
            {
                Console.WriteLine("Mr." + name);
            }
            else if(gender=='F' || gender == 'f')
            {
                Console.WriteLine("Ms."+ name);
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
            Console.ReadLine();
        }
    }
}
