using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class b9
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a First number : ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Second number : ");
            int b = Convert.ToInt32(Console.ReadLine());

            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> mul = (x, y) => x * y;
            Func<int, int, int> max = (x, y) => x>y ? x : y;

            Console.WriteLine("Addition : " + add(a, b));
            Console.WriteLine("Multiplication : " + mul(a, b));
            Console.WriteLine("Maximum number : " + max(a, b));

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
