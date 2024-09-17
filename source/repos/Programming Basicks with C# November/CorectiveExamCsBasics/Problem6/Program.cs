using System;

namespace Problem6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int locationCount = int.Parse(Console.ReadLine());
            double expectedAvaregeGoldIncomePerDay = 0;
            double averageGoldIncomePerDay = 0;
            int diggingDaysCountPerLocation = 0;

            for (int i = 1; i <= locationCount; i++)
            {
                expectedAvaregeGoldIncomePerDay = double.Parse(Console.ReadLine());
                 diggingDaysCountPerLocation = int.Parse(Console.ReadLine());

                for (int days = 1; days <= diggingDaysCountPerLocation; days++)
                {
                    double goldIncomePerDay = double.Parse(Console.ReadLine());
                    averageGoldIncomePerDay += goldIncomePerDay;
                    
                }
                if ((averageGoldIncomePerDay / diggingDaysCountPerLocation) >= expectedAvaregeGoldIncomePerDay)
                {
                    Console.WriteLine($"Good job! Average gold per day: {(averageGoldIncomePerDay / diggingDaysCountPerLocation):f2}.");
                }

                else if((averageGoldIncomePerDay / diggingDaysCountPerLocation) < expectedAvaregeGoldIncomePerDay)
                {
                    Console.WriteLine($"You need {(expectedAvaregeGoldIncomePerDay - (averageGoldIncomePerDay / diggingDaysCountPerLocation)):f2} gold.");
                }
                averageGoldIncomePerDay = 0;
            }
            
        }
    }
}
