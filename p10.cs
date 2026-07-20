using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p10
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter a Mobile number : ");
            str = Console.ReadLine();

            int n = str.Length;
            for(int i = 1; i<=n; i++)
            {
                if (i < n / 2)
                {
                    Console.Write(str[i]);

                }
                else
                {
                    Console.Write("X");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. :  24SOECE11043");
        }
    }
}
