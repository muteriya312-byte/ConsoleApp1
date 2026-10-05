using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a2
    {

            public static void Main()

            {

                int[] arr = new int[5];
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("Enter elements : " + i+" ");
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
            //Ascending order
            //Array.Sort(arr);
            
                for(int i = 0; i < 5; i++)
                {
                    for(int j=1; j < 5; j++)
                    {

                    int temp = arr[i];
                    arr[i]=arr[j];
                    arr[j]=temp; 
                    }
                }
            Console.WriteLine("Sorted Array");
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] + "");
                }
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.Read();
            }
        }
    
}