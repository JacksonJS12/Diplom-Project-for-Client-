using System;

namespace _06._Gold_Mine
{
    class Program
    {
        static void Main(string[] args)
        {
            double locations = double.Parse(Console.ReadLine());


            double gainedGoldPerDay = 0;
            double totalGainedGold = 0;
            double avaregeGain = 0;
            avaregeGain = 0;

            for (int k = 1; k <= locations; k++)
            {
                for (int i = 1; i <= 1; i++)
                {
                double expectExtraction = double.Parse(Console.ReadLine());
                int daysOnLocation = int.Parse(Console.ReadLine());
                    for (int j = 1; j <= daysOnLocation; j++)
                    {
                    gainedGoldPerDay = double.Parse(Console.ReadLine());
                        totalGainedGold += gainedGoldPerDay;
                        avaregeGain = totalGainedGold / daysOnLocation;

                    }
                    

                    totalGainedGold = 0;

                    
                }
            }
        }

    }
}
