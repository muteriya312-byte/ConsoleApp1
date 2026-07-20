using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class p18
    {
        static void Main(string[] args)
        {
            int k = 1;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(k + " ");
                    k++;
                }
                Console.WriteLine();
            }
        }
    }
}
