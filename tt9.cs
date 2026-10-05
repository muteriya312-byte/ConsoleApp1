using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Library
    {
        // Static variable
        public static string LibraryName = "RKU Central Library";

        protected int bookId;
        protected string bookTitle;

        // Base class constructor
        public Library(int id, string title)
        {
            bookId = id;
            bookTitle = title;
        }

        // Base class method
        public void ShowLibrary()
        {
            Console.WriteLine("Library Name : " + LibraryName);
        }

        // Base class display method
        public void Display()
        {
            Console.WriteLine("Book ID    : " + bookId);
            Console.WriteLine("Book Title : " + bookTitle);
        }
    }

    class Books : Library
    {
        private string author;

        // Constructor using this keyword
        public Books(int bookId, string bookTitle, string author)
            : base(bookId, bookTitle)   // base keyword
        {
            this.author = author;       // this keyword
        }

        // new keyword hides base class Display()
        public new void Display()
        {
            base.Display();             // call base class method
            Console.WriteLine("Author     : " + author);
        }
    }

    class tt9
    {
        static void Main(string[] args)
        {
            Books b1 = new Books(101, "ASP.Net", "Jaldhara");

            // Static member
            b1.ShowLibrary();

            Console.WriteLine("\nBook Details");
            b1.Display();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }
}
