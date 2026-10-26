using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
        }
    }
    class BankAccount11
    {
        double balance = 500000;
        public void withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new InsufficientBalanceException("Error :  Amount " +"Withdrawal Failed.");
            }
            balance -= amount;
            Console.WriteLine("Amount Withdrawal Successful. ");
            Console.WriteLine("Current Balance : " + balance);
        }
    }
    internal class b8
    {
        public static void Main(string[] args)
        {
            BankAccount11 b = new BankAccount11();
            try
            {
                Console.WriteLine("Enter Amount to Withdraw : ");
                double amount = Convert.ToDouble(Console.ReadLine());
                b.withdraw(amount);
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }   
    }
}
