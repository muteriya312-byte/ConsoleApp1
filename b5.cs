using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BankAccount
    {
        public delegate void DepositHandler();

        //public event delegatename nameofevent;

        public event DepositHandler DepositEvent;

        public void Deposit(double amount)
        {
            Console.WriteLine("Amount Deposited : " + amount);

            if(DepositEvent != null)
            {
                DepositEvent();  //calling an event
            }
        }
    }
    internal class b5
    {
        static void DepositMessage()
        {
            Console.WriteLine("Event : Amount de[posited successfully.");
        }
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount();

            account.DepositEvent += DepositMessage;
            account.Deposit(50000);

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
