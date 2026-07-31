using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class pp14
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry, total = 0;
            Console.WriteLine("Enter the marks obtained in Maths : ");
            maths = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks obtained in Physics : ");
            physics = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the marks obtained in Chemistry : ");
            chemistry = Convert.ToInt32(Console.ReadLine());

            total = maths + physics + chemistry;
            int mathphy = maths + physics;

            if((maths >= 65 && physics >=55 && chemistry>=50 && total >=180) || (maths >=65 &&  physics >=55 && mathphy >= 140))
            {
                Console.WriteLine("The candidate is eligible for Admission.");
            }
            else
            {
                Console.WriteLine("The candidate is Not eligible for Admission.");

            }
            Console.ReadLine();
        }
    }
}
