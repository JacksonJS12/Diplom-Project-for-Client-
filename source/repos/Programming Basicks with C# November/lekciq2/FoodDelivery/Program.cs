using System;

namespace FoodDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int numForChikenMenus = int.Parse(Console.ReadLine());
            int numForFishMenus = int.Parse(Console.ReadLine());
            int numForVeganMenus = int.Parse(Console.ReadLine());

            double numForChikenMenusPrice = numForChikenMenus * 10.35;
            double numForFishMenusPrice = numForFishMenus * 12.40;
            double numForVeganMenusPrice = numForVeganMenus * 8.15;

            double onlyMenusPrice = numForChikenMenusPrice + numForFishMenusPrice + numForVeganMenusPrice;

            double totalPrice = onlyMenusPrice + (onlyMenusPrice*0.2) + 2.50;

            Console.WriteLine(totalPrice);



        }
    }
}
