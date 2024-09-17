using System;

namespace _01._Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());

            double income = row * col;

            switch(projection)
            {
                case "Premiere":
                    income = income * 12.00;
                    break;
                case "Normal":
                    income *= 7.50;
                    break;
                        case "Discount":
                    income *= 5.00;
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{income:F2} leva");
        }
    }
}
