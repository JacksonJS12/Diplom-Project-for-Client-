using System;

namespace _02._Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageAstronaout = double.Parse(Console.ReadLine());

            double volume = width * length * height;
            double roomVolume = (averageAstronaout + 0.40) * 2 * 2;
            double people = volume / roomVolume;

            if (people >= 3 && people <= 10)
            {
                Console.WriteLine($"The spacecraft holds {Math.Floor(people)} astronauts.");
            }
            else if (people < 3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
