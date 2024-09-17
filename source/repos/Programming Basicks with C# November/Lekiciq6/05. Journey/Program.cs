using System;

namespace _05._Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string destination = "Europe";
            string type = "Hotel"; //"Camp" или "Hotel"
            double price = budget * 0.9;

            // if (budget <= 100) - в България - > Лято – 30% - къмпинг, Зима – 70 % хотел
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.3;
                }
                else
                {
                    type = "Hotel";
                    price = budget * 0.7;
                }
            }
            // else if (budget <= 1000) - Лято 40 % - къмпинг, Зима – 80 % хотел
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    type = "Camp";
                    price = budget * 0.4;
                }
                else
                {
                    type = "Hotel";
                    price = budget * 0.8;
                }

            }
            Console.WriteLine($"Somewhere in {destination:F2}");
            Console.WriteLine($"{type} - {price:F2}");



        }
    }
}
