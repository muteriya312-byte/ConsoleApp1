using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class b13
    {
        static void DisplayNumbers()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Number: " + i);
                Thread.Sleep(1000);
            }
        }

        static void DisplayAlphabets()
        {
            for (char c = 'A'; c <= 'E'; c++)
            {
                Console.WriteLine("Alphabet: " + c);
                Thread.Sleep(1000);
            }
        }

        static void Main()
        {
            Thread t1 = new Thread(DisplayNumbers);
            Thread t2 = new Thread(DisplayAlphabets);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();

            Console.WriteLine("Both threads completed.");

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }

}
