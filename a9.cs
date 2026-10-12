using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a9
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 };

            //int pos = 3; //delete 3rd element

            Console.WriteLine("Enter Position of element to delete :");

            int pos = Convert.ToInt32(Console.ReadLine());

            for(int i= pos-1;i<arr.Length-1;i++)
            {
                arr[i] = arr[i + 1];
            }
            Console.WriteLine("Array after deletion :");

            for(int i =0; i<arr.Length-1;i++  )
            {
                Console.WriteLine(arr[i]+" ");
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
