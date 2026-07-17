using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p21
    {
        static void Main(string[] args)
        {
            int terms, number;
            int current = 0;
            int sum = 0;

            Console.WriteLine("Enter terms : ");
            terms = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number : ");
            number = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=terms;i++)
            {
                current = current * 10 + number;
                Console.Write(current);
                sum += current;

                if (i < terms)
                    Console.Write("+");
                
            }
            Console.WriteLine("Sum is : " + sum);
            Console.ReadLine();
        }
    }
}
