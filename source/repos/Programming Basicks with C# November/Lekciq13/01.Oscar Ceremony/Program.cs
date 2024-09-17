using System;

namespace _01.Oscar_Ceremony
{
    class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            //Статуетки  – цената им е 30 % по - малка от наема на залата
            //Кетъринг – цената му е 15 % по - малка от тази на статуетките
            ////Озвучаване – цената му е 1 / 2 от цената за кетъринг

            double statues = rent * 0.70;
            double catering = statues - statues * 0.15;
            double audio = catering * 0.5;

            double total = rent + statues + catering + audio;
            Console.WriteLine($"{total:F2}");


        }
    }
}
