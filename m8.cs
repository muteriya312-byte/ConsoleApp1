using System;

namespace project1
{
    class X

    {

        public virtual void F() { Console.WriteLine("X.F"); }

        public virtual void F2() { Console.WriteLine("X.F2"); }

    }

    class Y : X

    {

        public override void F() { Console.WriteLine("Y.F"); }

        public override void F2() { Console.WriteLine("Y.F2"); }

    }

    class Z : Y

    {

        // Overriding F

        public override void F() { Console.WriteLine("Z.F"); }



        // Overriding F2

        public override void F2() { Console.WriteLine("Z.F2"); }

    }

    class m8

    {

        static void Main()

        {

            X Obj1 = new X();

            Obj1.F();

            Obj1.F2();


            Y Obj2 = new Y();

            Obj2.F();

            Obj2.F2();



            Z Obj3 = new Z();

            Obj3.F();

            Obj3.F2();
            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();

        }

    }
}