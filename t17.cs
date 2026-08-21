using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //virtual will allowed to change method/override in child classes
    //override keyword written in the child class's method.
   //virtual keyword written in the parents class's method.
    class Shape
    {
        public virtual void CalculatedArea()
        {
            Console.WriteLine("Area of Shape");
        }
    }
    class Circle : Shape
    {
        public override void CalculatedArea()
        {
            double radius = 5;
            double area = Math.PI * radius * radius;

            Console.WriteLine("Area of Circle = " + area.ToString("0.00"));
        }
    }
    class Rectangle : Shape
    {
        public override void CalculatedArea()
        {
            double length = 10;
            double width = 5;

            double area = length * width;

            Console.WriteLine("Area of Rectangle = " + area);
        }
    }
    class Triangle : Shape
    {
        public override void CalculatedArea()
        {
            double b = 10;
            double h = 5;

            double area = 0.5 * b*h;
            Console.WriteLine("Area of Triangle = " + area);
        }
    }
    internal class t17
    {
        static void Main(string[] args)
        {
            Shape shape;

            //circle
            shape = new Circle();
            shape.CalculatedArea();

            //rectangle
            shape = new Rectangle();
            shape.CalculatedArea();

            //triangle
            shape = new Triangle();
            shape.CalculatedArea();

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");

            Console.ReadLine();
        }
    }
}
