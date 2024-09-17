using System;
using System.Linq;

namespace MoreExerciseP02.PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[] currRow = new int[rows];
            int[] lastRow = new int[rows];

            for (int row = 1; row <= rows; row++)
            {
                lastRow = currRow;
                currRow = new int[row];

               




            }
        }
    }
}
