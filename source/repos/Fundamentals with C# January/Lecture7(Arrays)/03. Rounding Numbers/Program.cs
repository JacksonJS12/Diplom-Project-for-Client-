using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          double[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < array.Length; i++)
            {
                double oldSum = array[i];

                double newSum = Math.Round(oldSum, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{Convert.ToDecimal(oldSum)} => {Convert.ToDecimal(newSum)}");

            }
            //foreach (double oldSum in array)
            //{
            //    double newSum = Math.Round(oldSum, 0, MidpointRounding.AwayFromZero);
            //    Console.WriteLine($"{oldSum} => {newSum}");
            //}
        }
    }
}
