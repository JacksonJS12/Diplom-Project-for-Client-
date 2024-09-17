using System;

namespace _03._Final_Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            int dancersCount = int.Parse(Console.ReadLine());
            double points = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string place = Console.ReadLine();

            double priceReward = points * dancersCount;
            double costs = 0.0;
            double sumAfterCosts = 0.0;
            if (place == "Bulgaria")
            {
                priceReward = points * dancersCount;
                if (season == "summer")
                {
                    costs = priceReward * 0.05;
                    sumAfterCosts = priceReward - costs;
                }
               else if (season == "winter")
                {
                    costs = priceReward * 0.08;
                    sumAfterCosts = priceReward - costs;
                }
            }
            else if(place == "Abroad")
            {
                priceReward = priceReward + priceReward * 0.50;
                if (season == "summer")
                {
                    costs = priceReward * 0.10;
                    sumAfterCosts = priceReward - costs;
                }
                else if (season == "winter")
                {
                    costs = priceReward * 0.15;
                    sumAfterCosts = priceReward - costs;
                }
            }

            double charity = sumAfterCosts * 0.75;
            double moneyPerDancer = (sumAfterCosts - charity) / dancersCount;

            Console.WriteLine($"Charity - {charity:F2}");
            Console.WriteLine($"Money per dancer - {moneyPerDancer:F2}");
        }
    }
}
