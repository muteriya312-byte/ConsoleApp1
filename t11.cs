using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BankAccout
    {
        private int accountNo;
        private string accountHolder;
        private double balance;

        public BankAccout(int accNo, string holder , double ammount)
        {
            accountNo = accNo;
            accountHolder = holder;
            balance = ammount;
        }

        public void Deposit(double  amount)
        {
            balance += amount;
            Console.WriteLine("Amoount Deposited Successfully. ");
        }

        public void Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount Withdrawn successfully.");
            }
            else
            {
                Console.WriteLine("Insufficent Balance.");
            }
        }
        public void BalanceEnquiry()
        {
            Console.WriteLine("\n Account No :" + accountNo);
            Console.WriteLine("Account Holder :" + accountHolder);
            Console.WriteLine("Current Blanace :" + balance);
        }
    }

    class t11
    {
        static void Main(string[] args)
        {
            BankAccout acc1 = new BankAccout(1001, "Mital", 50000);
            BankAccout acc2 = new BankAccout(1002, "Hiral", 40000);

            Console.WriteLine("Account 1 Transactions :");
            acc1.Deposit(2000);
            acc1.Withdraw(1000);
            acc1.BalanceEnquiry();

            Console.WriteLine("-----------------------");

            Console.WriteLine("Account 2 Transactions :");
            acc1.Deposit(1000);
            acc1.Withdraw(2000);
            acc1.BalanceEnquiry();


            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.WriteLine("Name : Mital Uteriya");

            Console.ReadLine();

        }
    }
}
