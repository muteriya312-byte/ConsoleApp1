using System;

// User-defined exception class
class MyException : Exception
{
    // Constructor accepting exception message
    public MyException(string str) : base(str)
    {
        //Console.WriteLine("User defined exception");
    }
}

// Main client class
class m10
{
    public static void Main()
    {
        try
        {
            // Throw user-defined exception
            throw new MyException("my exception generated.");
        }
        catch (Exception e)
        {
            // Display exception message
            Console.WriteLine("Exception caught here: " + e.Message);
        }

        // This statement executes after catch
        Console.WriteLine("LAST STATEMENT");
        Console.WriteLine("Name : Mital Uteriya");
        Console.WriteLine("Enrollment No. : 24SOECE11043");

        Console.ReadKey();
    }
}




