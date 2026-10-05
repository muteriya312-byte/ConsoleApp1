using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Collage
    {
        private string Name;
        protected string uni_name;
        public string department;


        public Collage(string name, string uni_name, string department)
        {
            this.Name = name;
            this.uni_name = uni_name;
            this.department = department;

        }

        public void DisplayName()
        {
            Console.WriteLine("Collage Name: " + Name);

        }

        public void DisplayUniname()
        {
            Console.WriteLine("University Name: " + uni_name);
        }
        public void DisplayDepartment()
        {
            Console.WriteLine("Department: " + department);
        }

        public void Display()
        {
            DisplayName();
            DisplayUniname();
            DisplayDepartment();
        }
    }

    // Derived class

    class SOE : Collage
    {
        private string Event_name;
        protected int cost_of_Event;
        public string co_ordinator_name;

        public SOE(string name, string uni_name, string department, string Event_name, int cost_of_Event, string co_ordinator_name)
            : base(name, uni_name, department)
        {
            this.Event_name = Event_name;
            this.cost_of_Event = cost_of_Event;
            this.co_ordinator_name = co_ordinator_name;
        }

        public void DisplayEventName()
        {
            Console.WriteLine("Event Name: " + Event_name);
        }

        public void DisplayCostOfEvent()
        {
            Console.WriteLine("Cost of Event: " + cost_of_Event);
        }

        public void DisplayCoOrdinatorName()
        {
            Console.WriteLine("Co-ordinator Name: " + co_ordinator_name);
        }

        public void DisplaySOE()
        {
            Display();
            DisplayEventName();
            DisplayCostOfEvent();
            DisplayCoOrdinatorName();
        }

    }



    class m3
    {
        static void Main(string[] args)
        {
            

            SOE s = new SOE("Gloabal", "RKU", "Computer Engineering", "Tech Fest", 10000, "arjun");

            s.Display();
            s.DisplaySOE();

            Console.WriteLine("\n");

            SOE s1 = new SOE("Nobal", "GTU", "Computer science", "nursing", 20000, "sahil");

            s1.Display();
            s1.DisplaySOE();
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");

            Console.ReadLine();

        }

    }
}