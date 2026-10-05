using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a4
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 40, 50, 60, 70 };
            int[] arr2 = new int[arr1.Length];

            Console.WriteLine("Array1 elements");
            for(int i =0;  i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            //Array.Copy(arr1, arr2, arr1.Length);
            Console.WriteLine("Array2 elements");

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
