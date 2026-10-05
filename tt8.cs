using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Payment
    {
        // Abstract method
        public abstract void CalculatePayment();
    }

    class CashPayment : Payment
    {
        private double amount;

        public CashPayment(double amt)
        {
            amount = amt;
        }

        public override void CalculatePayment()
        {
            Console.WriteLine("Cash Payment Amount = " + amount);
        }
    }

    class CardPayment : Payment
    {
        private double amount;

        public CardPayment(double amt)
        {
            amount = amt;
        }

        public override void CalculatePayment()
        {
            double finalAmount = amount + 50; // Processing charge
            Console.WriteLine("Card Payment Amount = " + finalAmount);
        }
    }

    class tt8
    {
        static void Main(string[] args)
        {
            Payment p1 = new CashPayment(1000);
            Payment p2 = new CardPayment(1000);

            p1.CalculatePayment();
            p2.CalculatePayment();

            Console.WriteLine("Name : Jaldhara Jadav");
            Console.WriteLine("Enrollment No. : 24SOECE11011");

            Console.ReadLine();
        }
    }
}
