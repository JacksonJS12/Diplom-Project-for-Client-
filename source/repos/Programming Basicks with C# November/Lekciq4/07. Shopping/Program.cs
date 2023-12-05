using System;

namespace _07._Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardQuantity = int.Parse(Console.ReadLine());
            int cpuQuantity = int.Parse(Console.ReadLine());
            int ramQuantity = int.Parse(Console.ReadLine());

            int videoCardPrice = 250;
            double forVideoCard = videoCardPrice * videoCardQuantity;

            double cpuPrice = forVideoCard * 0.35;
            double forCpu = cpuQuantity * cpuPrice;

            double ramPrice = forVideoCard * 0.1;
            double forRam = ramQuantity * ramPrice;

            double costs = forVideoCard + forCpu + forRam;
            double discount = 0;
            if (videoCardQuantity > cpuQuantity)
            {
                discount = costs * 0.15;
            }
            else if (videoCardQuantity <= cpuQuantity)
            {
                discount = 0;
            }
            double difference = budget - (costs - discount);
            if (budget > costs)
            {
                Console.WriteLine($"You have {difference:F2} leva left!");
            }
            else if (budget < costs)
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! You need {difference:F2} leva more!");
            }


            

            
            



        }
    }
}
