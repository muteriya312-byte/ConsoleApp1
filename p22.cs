using System;

class p22
{
    static void Main()
    {
        int n = 5; 
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = n - 1; i >= 1; i--)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write(" ");
            }

            for (int j = 1; j <= (2 * i - 1); j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}