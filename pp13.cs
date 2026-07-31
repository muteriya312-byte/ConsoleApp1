using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pp13
    {
        static void Main(string[] args)
        {
            int amount;
            Console.WriteLine("Enter Amount :");
            amount = Convert.ToInt32(Console.ReadLine());

            int[] notes = { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };

            foreach (int note in notes)
            {
                int count = amount / note;
                Console.WriteLine("Notes of Rs. {0} = {1}", note, count);
                amount = amount % note;

            }
            Console.ReadLine();
        }
    }
}
