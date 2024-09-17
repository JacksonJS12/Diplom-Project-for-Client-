using System;

namespace _01.ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            decimal totalPriceWithNoTax = 0;

            while (command != "regular" && command != "special")
            {
                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }


                totalPriceWithNoTax += price;

                command = Console.ReadLine();
            }

            if (totalPriceWithNoTax == 0)
            {
                Console.WriteLine("Invalid order!");
                command = Console.ReadLine();
                return;
            }
            else
            {

                decimal taxes = totalPriceWithNoTax * 0.2m;

                if (command == "special")
                {
                    decimal totalWihtTaxes = totalPriceWithNoTax + taxes;
                    decimal totalPriceWithDiscount = totalWihtTaxes * 0.9m;

                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithNoTax:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {totalPriceWithDiscount:f2}$");
                }
                else
                {
                    Console.WriteLine("Congratulations you've just bought a new computer!");
                    Console.WriteLine($"Price without taxes: {totalPriceWithNoTax:f2}$");
                    Console.WriteLine($"Taxes: {taxes:f2}$");
                    Console.WriteLine("-----------");
                    Console.WriteLine($"Total price: {(totalPriceWithNoTax + taxes):f2}$");
                }
            }
        }
    }
}
