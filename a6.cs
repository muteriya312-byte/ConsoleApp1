using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a6
    {
        public static void Main(string[] args)
        {
            int[] arr = { 50, 100, 154, 214, 365 };

            int max = arr[0];
            int min = arr[0];

            for(int i=1; i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum Element : " + max);
            Console.WriteLine("Minimum Element : " + min);



            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
