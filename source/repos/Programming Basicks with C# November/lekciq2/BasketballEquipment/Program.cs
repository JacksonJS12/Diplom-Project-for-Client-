using System;

namespace BasketballEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            // от конзолата да прочетем таксата за една година
              int taxPerYear = int.Parse(Console.ReadLine());

            //  Баскетболни кецове, екип, топка, аксесоари
            double trainersPrice = taxPerYear - (taxPerYear * 0.4);
            double outfitPrice = trainersPrice - (trainersPrice * 0.2);
            double ballPrice = outfitPrice / 4;
            double accPrice = ballPrice / 5;

            //  сумата на всички разходи
            double expenses = taxPerYear + trainersPrice + outfitPrice + ballPrice + accPrice;
            //  изведем на конзолата сумата
            Console.WriteLine(expenses);




        }
    }
}
