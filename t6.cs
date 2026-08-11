using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Line
    {
        private double length;

        public Line()
        {
            Console.WriteLine("Object creating value length = 10");

            length = 10;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public double getLength()
        {
            return length;
        }
    }
    class t6

    {

        static void Main(string[] args)

        {

            Line line = new Line();

            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());
            line.setLength(6);
            // set line length

            Console.WriteLine("Length of line : {0}", line.getLength());

            Console.ReadKey();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment no. : 24SOECE11043");

        }

    }

}

