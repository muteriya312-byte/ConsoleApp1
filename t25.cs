using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class t25
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            //remove unnecessary spaces
            password = password.Trim();

            Console.WriteLine("Password Details");
            Console.WriteLine("-----------------------------");

            //display password length
            Console.WriteLine("Password Length : "+ password.Length);

            //validation password length
            if(password.Length < 8)
            {
                Console.WriteLine("Password must contain at least 8 characters.");
            }
            else
            {
                Console.WriteLine("Password Length is valid.");

                //check for sepical character
                if(password.Contains(" @") || password.Contains("#")|| password.Contains("$"))
                 {
                    Console.WriteLine("Sepcial character : Available");

                }
                else {

                    Console.WriteLine("Sepcial character : Not Available");
                }
                Console.WriteLine("Uppercase Password : "+ password.ToUpper());
                Console.WriteLine("Uppercase Password : " + password.ToLower());

                string modifiedPassword = password.Replace("@", "#");
                Console.WriteLine("Modified password : " + modifiedPassword);


            }



            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
        }
    }
}
