using System;

namespace _04._Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEggs = int.Parse(Console.ReadLine());

            int redEggsCounter = 0;
            int blueEggsCounter = 0;
            int orangeEggsCounter = 0;
            int greenEggsCounter = 0;

            int maxEggsCounter = 0;
            string color = "";

            for (int i = 0; i < numOfEggs; i++)
            {
                string eggColor = Console.ReadLine();
                switch (eggColor)
                {
                    case "red":
                        redEggsCounter++;
                        if (redEggsCounter > maxEggsCounter)
                        {
                            maxEggsCounter = redEggsCounter;
                            color = eggColor;
                        }
                        break;
                    case "blue":
                        blueEggsCounter++;
                        if (blueEggsCounter > maxEggsCounter)
                        {
                            maxEggsCounter = blueEggsCounter;
                            color = eggColor;
                        }
                        break;
                    case "orange":
                        orangeEggsCounter++;
                        if (orangeEggsCounter > maxEggsCounter)
                        {
                            maxEggsCounter = orangeEggsCounter;
                            color = eggColor;
                        }
                        break;
                    case "green":
                        greenEggsCounter++;
                        if (greenEggsCounter > maxEggsCounter)
                        {
                            maxEggsCounter = greenEggsCounter;
                            color = eggColor;
                        }
                        break;
                }

            }
            // •"Red eggs: {брой на червените яйца}"
            //•	"Orange eggs: {брой на оранжевите яйца}"
            //•	"Blue eggs: {брой на сините яйца}"
            //•	"Green eggs: {брой на зелените яйца}"
            //•	"Max eggs: {максимален брой на яйцата от цвят} -> {цвят}"

            Console.WriteLine($"Red eggs: {redEggsCounter}");
            Console.WriteLine($"Orange eggs: {orangeEggsCounter}");
            Console.WriteLine($"Blue eggs: {blueEggsCounter}");
            Console.WriteLine($"Green eggs: {greenEggsCounter}");
            Console.WriteLine($"Max eggs: {maxEggsCounter} -> {color}");

        }
    }
}
