using System;
using System.Collections.Generic;
using System.Text;


namespace ConsoleApp1

{

    class StaticVar

    {

        public static int num;



        public void count()

        {

            num++;

        }
        public static int getNum()

        {

            return num;

        }

    }

    class m4

    {

        static void Main(string[] args)

        {

            StaticVar s = new StaticVar();

            s.count();

            s.count();

            s.count();

            Console.WriteLine("Variable num: {0}", StaticVar.getNum());

            
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();

        }

    }

}