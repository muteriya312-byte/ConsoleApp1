using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        // Private data members
        private int productCode;
        private string productName;
        private double price;

        // Constructor
        public Product(int code, string name, double p)
        {
            productCode = code;
            productName = name;
            price = p;
        }

        // Method to calculate 10% discount
        public double CalculateDiscount()
        {
            return price * 0.10;
        }

        // Method to calculate final price
        public double FinalPrice()
        {
            return price - CalculateDiscount();
        }

        // Method to display product details
        public void Display()
        {
            Console.WriteLine("\nProduct Details");
            Console.WriteLine("Product Code : " + productCode);
            Console.WriteLine("Product Name : " + productName);
            Console.WriteLine("Price        : " + price);
            Console.WriteLine("Discount     : " + CalculateDiscount());
            Console.WriteLine("Final Price  : " + FinalPrice());
        }
    }

    class tt4
    {
        static void Main(string[] args)
        {
            int code;
            string name;
            double price;

            Console.Write("Enter Product Code: ");
            code = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Product Name: ");
            name = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            price = Convert.ToDouble(Console.ReadLine());

            // Create object using constructor
            Product p1 = new Product(code, name, price);

            // Display details
            p1.Display();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }
}
