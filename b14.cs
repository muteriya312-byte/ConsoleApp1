using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class b14
    {
        static void Display()
        {
            Console.WriteLine("Thread is running...");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Value: " + i);
                Thread.Sleep(500);
            }

            Console.WriteLine("Thread execution completed.");
        }

        static void Main()
        {
            Thread t = new Thread(Display);

            Console.WriteLine("Before Start: " + t.ThreadState);

            t.Start();

            Console.WriteLine("After Start: " + t.ThreadState);

            t.Join();

            Console.WriteLine("After Join: " + t.ThreadState);
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }

}
