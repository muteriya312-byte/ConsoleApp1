using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Book
     {
        // Properties
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        // Constructor
        public Book(int id, string title, string author, double price)
        {
            BookID = id;
            Title = title;
            Author = author;
            Price = price;
        }

        // Method to display book details
        public void Display()
        {
            Console.WriteLine("Book ID : " + BookID);
            Console.WriteLine("Title   : " + Title);
            Console.WriteLine("Author  : " + Author);
            Console.WriteLine("Price   : " + Price);
            Console.WriteLine("---------------------------");
        }
    }

    class tt5
    {
        static void Main(string[] args)
        {
            // Create multiple book objects
            Book b1 = new Book(101, "C# Programming", "Jaldhara", 450);
            Book b2 = new Book(102, "ASP.NET Basics", "Mital", 550);
            Book b3 = new Book(103, "Database Systems", "Hiral", 600);

            // Display details
            b1.Display();
            b2.Display();
            b3.Display();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }

}
