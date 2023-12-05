using System;

namespace _01._Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            double averageSpeed = double.Parse(Console.ReadLine());
            double propellantPer100km = double.Parse(Console.ReadLine());

            double time = 768800 / averageSpeed;
            double totalTime = Math.Ceiling(time) + 3;

           double neededPropellant = (propellantPer100km * 768800) / 100;

            Console.WriteLine(totalTime);
            Console.WriteLine(neededPropellant);
        }
    }
}
