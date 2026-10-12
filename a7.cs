using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a7
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 15, 20, 25, 30, 35, 40 };

            int[] even = new int[arr.Length];
            int[] odd = new int[arr.Length];

            int e = 0, o = 0;

            for(int i = 0; i< arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even[e] = arr[i];
                    e++;
                }
                else
                {
                    odd[o] = arr[i];
                    o++;
                }
            }
            Console.WriteLine("Even elemets :");
            for(int i = 0; i < e; i++)
            {
                Console.WriteLine(even[i] + " ");
            }
            Console.WriteLine("Odd elemets :");
            for (int i = 0; i < o; i++)
            {
                Console.WriteLine(odd[i] + " ");
            }


            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
