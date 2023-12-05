using System;

namespace USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            /* четем от конзолата - duouble USD
               изчисления
               печатаме BGN 
               */

            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;

            Console.WriteLine(BGN);
        }
    }
}
