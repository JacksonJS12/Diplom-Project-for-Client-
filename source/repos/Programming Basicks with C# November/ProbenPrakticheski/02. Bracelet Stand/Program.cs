using System;

namespace _02._Bracelet_Stand
{
    class Program
    {
        static void Main(string[] args)
        {
            double pocketMoney = double.Parse(Console.ReadLine());
            double profit = double.Parse(Console.ReadLine());
            double costs = double.Parse(Console.ReadLine());
            double presentPrice = double.Parse(Console.ReadLine());

            double totalPocketMoney = pocketMoney * 5;
            double totalProfit = profit * 5;
            double totalSavedMoney = totalPocketMoney + totalProfit;
            double totalSum = totalSavedMoney - costs;

            if (totalSum >= presentPrice)
            {
                Console.WriteLine($"Profit: {totalSum:F2} BGN, the gift has been purchased.");
            }
            else
            {
                double difference = Math.Abs(presentPrice - totalSum);
                Console.WriteLine($"Insufficient money: {difference:F2} BGN.");
            }
        }
    }
}
