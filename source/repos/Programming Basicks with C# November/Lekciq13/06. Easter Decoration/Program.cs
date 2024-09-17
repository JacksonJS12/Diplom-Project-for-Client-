using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCustomers = int.Parse(Console.ReadLine());

            double totalMoneySpent = 0;

            for (int i = 0; i < numOfCustomers; i++)
            {

                int itemsCounter = 0;
                double total = 0;

                string item = Console.ReadLine();

                while (item != "Finish")

                {
                    itemsCounter++;

                    switch (item)
                    {
                        case "basket":
                            total += 1.50;
                            break;
                        case "wreath":
                            total += 3.80;
                            break;
                        case "chocolate bunny":
                            total += 7;
                            break;
                    }

                    item = Console.ReadLine();

                }
                if (itemsCounter % 2 == 0)
                {
                    total *= 0.80;
                }
                totalMoneySpent += total;
                Console.WriteLine($"You purchased {itemsCounter} items for {total:F2} leva.");
            }
            double average = totalMoneySpent / numOfCustomers;

            Console.WriteLine($"Average bill per client is: {average:F2} leva.");
        }
    }
}
