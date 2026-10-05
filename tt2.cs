using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class tt2
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            double average;

            Console.Write("Enter the number of elements: ");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            // Input array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element " + (i + 1) + ": ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Calculate sum
            for (int i = 0; i < n; i++)
            {
                sum = sum + arr[i];
            }

            // Calculate average
            average = (double)sum / n;

            Console.WriteLine("Sum = " + sum);
            Console.WriteLine("Average = " + average);

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");


            Console.ReadLine();
        }
    }
}
