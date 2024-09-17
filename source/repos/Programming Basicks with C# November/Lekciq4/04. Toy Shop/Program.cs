using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacPrice = double.Parse(Console.ReadLine());

            int puzzleQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            int toysCount = puzzleQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;

            double puzzlePrice = puzzleQuantity * 2.6;
            double bearsPrice = bearsQuantity * 4.1;
            double dollsPrice = dollsQuantity * 3.0;
            double minionsPrice = minionsQuantity * 8.2;
            double trucksPrice = trucksQuantity * 2.0;

            double profit = puzzlePrice + bearsPrice + dollsPrice + minionsPrice + trucksPrice;

            if(toysCount >= 50)
            {
                profit = profit - profit * 0.25;
            }

            profit = profit - profit * 0.1;

            double difference = profit - vacPrice;

            if (difference>=0)
            {
                Console.WriteLine($"Yes! {difference:F2} lv left.");
            }
            else
            {
                difference = Math.Abs(difference);
                Console.WriteLine($"Not enough money! {difference:F2} lv needed.");
            }
        }
    }
}
