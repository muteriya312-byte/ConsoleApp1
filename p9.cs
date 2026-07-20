using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p9
    {
        static void Main(string[] args)
        {
            String str;
            Console.WriteLine("Enter a String for Toggle case :");
            str = Console.ReadLine();

            String result = " ";

            foreach(Char ch in str)
            
                if (Char.IsUpper(ch))
                {
                    result += Char.ToLower(ch);
                }
                else
                {
                    result += Char.ToUpper(ch);
                }
                Console.WriteLine(result);

            
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. :  24SOECE11043");
        }
    }
}
