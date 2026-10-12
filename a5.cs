using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a5
    {
        public static void Main(string[] args)
        {
            int[] arr = { 10, 20, 10, 30, 20, 40, 10 };
            for(int i = 0; i<arr.Length; i++)
            {
                int count = 0;
                for(int j = 0; j<arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                  
                }
                if (count > 1)
                {
                    Console.WriteLine(arr[i] + " occurs" + count + " times");
                }
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }

    }
}
