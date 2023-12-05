using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0.00;

            if (type == "Roses")
            {
                price = flowersCount * 5.00;
                if (flowersCount > 80)
                {
                    price = price - price * 0.10;
                }
            }
            else if (type == "Dahlias")
            {
                price = flowersCount * 3.80;
                if (flowersCount > 90)
                {
                    price = price - price * 0.15;
                }
            }
            else if (type == "Tulips")
            {
                price = flowersCount * 2.80;
            }
            if (flowersCount > 80)
            {
                price = price - price * 0.15;
            }
            else if (type == "Narcissus")
            {
                price = flowersCount * 3.00;
            }
            if (flowersCount < 120)
            {
                price = price + price * 0.15;
            }
            else if (type == "Gladiolus")
            {
                price = flowersCount * 2.50;
                if (flowersCount < 80)
                {
                    price = price + price * 0.20;
                }
            }

            if (budget < price)
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
            else
            {

                Console.Write($"Hey, you have a great garden with {flowersCount} {type} and {budget - price:F2} leva left.");
            }


        }

    }
}

