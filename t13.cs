using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ProductDetails
    {
        public int proid {  get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }

        public double CalculateBill()
        {
            return price * quantity;
        }
        public void Display()
        {
            Console.WriteLine("\nProduct Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Product ID :" + proid);
            Console.WriteLine("Product name :"+name);
            Console.WriteLine("Price :" + price);
            Console.WriteLine("Quantity :" + quantity);
            Console.WriteLine("Bill Amount :"+CalculateBill());
        }
    }
    class t13
    {
        public static void Main(string[] args)
        {
            ProductDetails p = new ProductDetails();

            Console.WriteLine("Enter product ID :");
            p.proid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter product name :");
            p.name = Console.ReadLine();

            Console.WriteLine("Enter price :");
            p.price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter quantity :");
            p.quantity = Convert.ToInt32(Console.ReadLine());

            p.Display();

            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();
        }
    }
}
