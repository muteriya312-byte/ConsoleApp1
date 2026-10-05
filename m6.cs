using System;

abstract class Test

{

    public int a;

    public abstract void A();

}



class Example1 : Test

{

    public override void A()

    {

        Console.WriteLine("Example1.A");

        base.a++;

    }

}

class Example2 : Test

{

    public override void A()

    {

        Console.WriteLine("Example2.A");

        base.a--;

    }

}

class m6

{

    static void Main()

    {

        // Reference Example1 through Test type.

        Test test1 = new Example1();

        test1.A();

        // Reference Example2 through Test type.

        Test test2 = new Example2();

        test2.A();



        Console.WriteLine("Name : Mital Uteriya");
        Console.WriteLine("Enrollment No. : 24SOECE11043");
       
        Console.ReadLine();


    }

}