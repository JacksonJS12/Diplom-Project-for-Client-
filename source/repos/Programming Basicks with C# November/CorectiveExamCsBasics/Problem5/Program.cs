using System;

namespace Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int purchasedDogFood = int.Parse(Console.ReadLine()) * 1000;

            string command = Console.ReadLine();
            int totalEatenFood = 0;
            while (command != "Adopted")
            {
                int eatenFoodPerMeal = int.Parse(command);
                totalEatenFood += eatenFoodPerMeal;

                command = Console.ReadLine();
            }
                if (totalEatenFood <= purchasedDogFood)
                {
                    Console.WriteLine($"Food is enough! Leftovers: {purchasedDogFood - totalEatenFood} grams.");
                }
                else
                {
                    Console.WriteLine($"Food is not enough. You need {totalEatenFood - purchasedDogFood} grams more.");
                }
        }
    }
}
