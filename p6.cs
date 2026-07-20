using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p6
    {
        static void Main(string[] args)
        {
            int a, b, c, result;
            Console.WriteLine("Enter number 1 : ");
            String str = Console.ReadLine();
            a = Convert.ToInt32(str);

            Console.WriteLine("Enter number 2 : ");
            String str1 = Console.ReadLine();
            b = Convert.ToInt32(str1);

            Console.WriteLine("Enter number 3 : ");
            String str2 = Console.ReadLine();
            c = Convert.ToInt32(str2);

            result = a + b + c;
            Console.WriteLine("Result is : " + result);

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. :  24SOECE11043");
            Console.ReadLine();
        }
    }
}
