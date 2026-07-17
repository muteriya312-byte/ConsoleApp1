using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pp4
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Enetr First Number : ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enetr Second Number : ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Arithmetic Operators");
            Console.WriteLine("Addition : "+ (a+b));
            Console.WriteLine("Subtraction : "+ (a-b));
            Console.WriteLine("Multiplication : " +(a*b));

            if (b != 0)
            {
                Console.WriteLine("Division : "+(a/b));
                Console.WriteLine("Modulus : "+(a%b));

            }
            else
            {
                Console.WriteLine("Division  = Cannot divide by Zero ! ");
                Console.WriteLine("Modulud  =  Cannot divide by Zero !");

            }

            Console.WriteLine("Relational Operators");
            Console.WriteLine("a > b :"+ (a>b));
            Console.WriteLine("a < b :" +(a<b));
            Console.WriteLine("a == b :"+(a==b));
            Console.WriteLine("a != b :" +(a!=b));

            Console.WriteLine("Logical Operators");
            Console.WriteLine("Both are positive (&&) : "+ (a>0 && b>0));
            Console.WriteLine("At least one is positive(||) :"+ (a>0||b>0));
            Console.WriteLine("Are they NOT equal (!) : "+ !(a==b));

            Console.ReadLine();


        }
    }
}
