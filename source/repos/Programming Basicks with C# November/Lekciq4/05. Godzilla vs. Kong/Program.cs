using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double clothing = statists * clothingPrice;

            if (statists >= 150)
            {
                clothing = clothing - clothing * 0.1;
            }

            double neededMoney = clothing + decor;

            double difference = budget - neededMoney;

            if(difference>=0)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money!");
                Console.WriteLine($"Wingard needs { difference:F2} leva more.");
            }



        }
    }
}
