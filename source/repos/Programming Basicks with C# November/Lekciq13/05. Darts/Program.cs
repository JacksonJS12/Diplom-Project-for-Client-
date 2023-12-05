using System;

namespace _05._Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int points = 301;
            int succsessfulShots = 0;
            int unsuccsessfulShots = 0;
            

            string sector = Console.ReadLine();
            while (sector != "Retire")
            {
                int currentPoints = int.Parse(Console.ReadLine());

                int totalCurrentPoits = 0;

                if (sector == "Single")
                {
                    totalCurrentPoits = currentPoints;
                }
                else if (sector == "Double")
                {
                    totalCurrentPoits = currentPoints * 2;
                }
                else if (sector == "Triple")
                {
                    totalCurrentPoits = currentPoints * 3;
                }

                if (points >= currentPoints)
                {
                    points -= currentPoints;
                    succsessfulShots++;
                }
                else
                {
                    unsuccsessfulShots++;
                }

                if (points == 0)
                {
                    Console.WriteLine($"{name} won the leg with {succsessfulShots} shots.");
                    break;
                }

                sector = Console.ReadLine();


            }
            if (points != 0)
            { 
                Console.WriteLine($"{name} retired after {unsuccsessfulShots} unsuccessful shots.");
            }
        }
    }
}
