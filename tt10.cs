using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class LibraryAccount
    {
        // Private data member
        private int issuedBooks;

        // Constructor
        public LibraryAccount()
        {
            issuedBooks = 0;
        }

        // Method to issue a book
        public void IssueBook()
        {
            issuedBooks++;
            Console.WriteLine("Book Issued Successfully.");
        }

        // Method to return a book
        public void ReturnBook()
        {
            if (issuedBooks > 0)
            {
                issuedBooks--;
                Console.WriteLine("Book Returned Successfully.");
            }
            else
            {
                Console.WriteLine("No books to return.");
            }
        }

        // Method to display issued books
        public void DisplayBooks()
        {
            Console.WriteLine("Number of Issued Books: " + issuedBooks);
        }
    }

    class tt10
    {
        static void Main(string[] args)
        {
            // Create multiple objects
            LibraryAccount student1 = new LibraryAccount();
            LibraryAccount student2 = new LibraryAccount();

            Console.WriteLine("Student 1");
            student1.IssueBook();
            student1.IssueBook();
            student1.DisplayBooks();

            Console.WriteLine();

            Console.WriteLine("Student 2");
            student2.IssueBook();
            student2.ReturnBook();
            student2.DisplayBooks();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");


            Console.ReadLine();
        }
    }
}
