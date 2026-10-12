using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a8
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 26, 15, 20, 25, 30, 40, 35 };

            Array.Sort(arr);
            Array.Reverse(arr);

            Console.WriteLine("Descending Order");
            for(int i = 0; i< arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
