using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class a10
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter row size :");
            int r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter column size :");
            int c = Convert.ToInt32(Console.ReadLine());

            int[,] matrix1 = new int[r, c];
            int[,] matrix2 = new int[r, c];
            int[,] result = new int[r, c];

            for(int i =0; i < r; i++)
            {
                for(int j =0; j<c; j++)
                {
                    Console.WriteLine("Enter Matrix-1 elements :");
                    matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine("Enter Matrix-2 elements :");
                    matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i =0; i<r; i++)
            {
                for(int j=0; j<c; j++)
                {
                    result[i,j] = matrix1[i,j] + matrix2[i,j];
                }
            }

            Console.WriteLine("Addition of Two Matrices");
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.WriteLine(result[i, j] + " ");
                }
            }

            Console.WriteLine("Name : Mital Uteriya");
            Console.WriteLine("Enrollment No. : 24SOECE11043");
            Console.ReadLine();
        }
    }
}
