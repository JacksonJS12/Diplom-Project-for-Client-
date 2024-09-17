using System;

namespace _01._PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double cpuPriceInUSD = double.Parse(Console.ReadLine());
            double gpuPriceInUSD = double.Parse(Console.ReadLine());
            double ramPriceInUSD = double.Parse(Console.ReadLine());
            int ramCount = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double cpuPriceInBGN = cpuPriceInUSD * 1.57;
            double gpuPriceInBGN = gpuPriceInUSD * 1.57;
            double ramPriceInBGN = ramPriceInUSD * 1.57;
            double totalRamPiceInBGN = ramPriceInBGN * ramCount;

            double finalCpuPrice = cpuPriceInBGN - (cpuPriceInBGN * discount);
            double finalGpuPrice = gpuPriceInBGN - (gpuPriceInBGN * discount);

            double totalPrice = finalCpuPrice + finalGpuPrice + totalRamPiceInBGN;

            Console.WriteLine($"Money needed - {totalPrice:F2} leva.");
        }
    }
}
