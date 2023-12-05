using System;

namespace _04._Cat_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int catCount = int.Parse(Console.ReadLine());

            int catGroup1 = 0;
            int catGroup2 = 0;
            int catGroup3 = 0;

            double foodQuantity = 0;

            double foodQuantity1 = 0;
            
            

            for (int i = 1; i <= catCount; i++)
            {
                foodQuantity = double.Parse(Console.ReadLine());
                if (foodQuantity >= 100 && foodQuantity <200)
                {
                    catGroup1++;
                    foodQuantity1 += foodQuantity ;
                }
                else if (foodQuantity >= 200 && foodQuantity < 300)
                {
                    catGroup2++;
                    foodQuantity1 += foodQuantity ;
                }
                else if (foodQuantity >= 300 && foodQuantity < 400)
                {
                    catGroup3++;
                    foodQuantity1 += foodQuantity ;
                }
                
            }
            double totalPrice =  foodQuantity1 ;

            Console.WriteLine($"Group 1: {catGroup1} cats.");
            Console.WriteLine($"Group 2: {catGroup2} cats.");
            Console.WriteLine($"Group 3: {catGroup3} cats.");
            Console.WriteLine($"Price for food per day: {totalPrice / 1000 * 12.45:F2} lv.");
        }
    }
}
