using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an Array : ");
            int n = Convert.ToInt32 (Console.ReadLine());

            int[] arr = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter elements : " + i + " ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Reverse order element ");
            for ( int i =n-1; i>=0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
        
    }
}
