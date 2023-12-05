using System;
using System.Collections.Generic;

namespace P01.Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<double> c = new List<double>();
            List<double> f = new List<double>();
            List<double> k = new List<double>();

            for (int i = 0; i <= 100; i++)
            {
                double tempC = i;
                double tempF = TemperatureInF(tempC);
                double tempK = TemperatureInK(tempC);

                c.Add(tempC);
                f.Add(tempF);
                k.Add(tempK);
            }

            Console.WriteLine("| C | F | K |");
            for (int i = 0; i < c.Count; i++)
            {
                Console.WriteLine($"| {c[i]} | {f[i]:F2} | {k[i]:F2} |");
            }
        }

       
        static double TemperatureInF(double currentTempInC)
        {
            return 1.8 * currentTempInC + 32; ;
        }
        static double TemperatureInK(double currentTempInC)
        {
            return currentTempInC + 273.15;
        }

    }

}
