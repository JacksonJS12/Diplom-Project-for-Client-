using System;

namespace _04._Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double price = 0.00;
            //"Spring" = 3000,("Summer", "Autumn") = 4200. "Winter" = 2600
            switch (season)
            {
                case "Spring":
                    price = 3000.00;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200.00;
                    break;
                case "Winter":
                    price = 2600.00;
                    break;
                default:
                    break;
            }

            //	Ако групата е до 6 човека включително = 10 %
            //	Ако групата е от 7 до 11 човека включително  = 15 %
            //	Ако групата е от 12 нагоре  = 25 %.

            if (fishermen <= 6)
            {
                price -= price * 0.10;
            }
            else if (fishermen <= 11)
            {
                price -= price * 0.15;
            }
            else
            {
                price -= price * 0.25;
            }

            // ако броят на рибарите е четен и !"Autumn" = 5%

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                price -= price * 0.05;
            }

            //дали бюджета е достатъчен

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:F2} leva.");
            }
        }
    }
}
