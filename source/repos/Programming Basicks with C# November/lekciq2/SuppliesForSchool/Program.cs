using System;

namespace SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int penPackets = int.Parse(Console.ReadLine());
            int packetsMarkers = int.Parse(Console.ReadLine());
            int boardCleaner = int.Parse(Console.ReadLine());
            double discount = int.Parse(Console.ReadLine());

            double penPacketsPrice = penPackets * 5.80;
            double packetsMarkersPrice = packetsMarkers * 7.20;
            double boardCleanerPrice = boardCleaner * 1.20;
            double discountPercent = discount/100;

            double sumWithoutDiscount = penPacketsPrice + packetsMarkersPrice + boardCleanerPrice;
            double totalSum = sumWithoutDiscount - (sumWithoutDiscount * discountPercent);
            Console.WriteLine(totalSum);

        }
    }
}
