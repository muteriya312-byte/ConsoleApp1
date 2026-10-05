using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vehicle
    {
        // Protected data members
        protected string vehicleNumber;
        protected string modelName;

        // Base class constructor
        public Vehicle(string number, string model)
        {
            vehicleNumber = number;
            modelName = model;
        }
    }

    class Car : Vehicle
    {
        private string carName;

        // Derived class constructor calling base constructor
        public Car(string number, string model, string name)
            : base(number, model)
        {
            carName = name;
        }

        // Method to display car details
        public void Display()
        {
            Console.WriteLine("\nCar Details");
            Console.WriteLine("Vehicle Number : " + vehicleNumber);
            Console.WriteLine("Model Name     : " + modelName);
            Console.WriteLine("Car Name       : " + carName);
        }
    }

    class tt6
    {
        static void Main(string[] args)
        {
            string number, model, name;

            Console.Write("Enter Vehicle Number: ");
            number = Console.ReadLine();

            Console.Write("Enter Model Name: ");
            model = Console.ReadLine();

            Console.Write("Enter Car Name: ");
            name = Console.ReadLine();

            // Create Car object
            Car c1 = new Car(number, model, name);

            // Display details
            c1.Display();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }
}
