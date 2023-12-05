using System;

namespace radiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            /* От конзолата получаваме: radians
               пробразуваме в degrees => degree=radians*180/pi (Math.PI)
               отпечатваме градусите
            */


            double radians = double.Parse(Console.ReadLine());
            double degrees = radians * 180 / Math.PI;

            Console.WriteLine(degrees);
        }
    }
}
