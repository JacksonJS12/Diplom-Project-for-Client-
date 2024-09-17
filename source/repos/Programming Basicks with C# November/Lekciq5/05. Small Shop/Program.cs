using System;

namespace _05._Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Read input
            //2. check the city
            //3. check the item

            //4. Set the price to the one from the table

            //5. Calculate the total amount (quantity * price)

            //6. Print the result
            //продукт coffee   water beer   sweets peanuts         CTR + K + C => komentira
            //Sofia   0.50    0.80    1.20    1.45    1.60        
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55

            string item = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            double price = 0;

            if (city == "Sofia")
            {
                if (item == "coffee")
                {
                    price = 0.50;
                }
                else if (item == "water")
                {
                    price = 0.80;
                }
                else if (item == "beer")
                {
                    price = 1.20;
                }
                else if (item == "sweets")
                {
                    price = 1.45;
                }
                else if (item == "peanuts")
                {
                    price = 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (item == "coffee")
                {
                    price = 0.40;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.15;
                }
                else if (item == "sweets")
                {
                    price = 1.30;
                }
                else if (item == "peanuts")
                {
                    price = 1.50;
                }
            }
            else if (city == "Varna")
            {
                if (item == "coffee")
                {
                    price = 0.45;
                }
                else if (item == "water")
                {
                    price = 0.70;
                }
                else if (item == "beer")
                {
                    price = 1.10;
                }
                else if (item == "sweets")
                {
                    price = 1.35;
                }
                else if (item == "peanuts")
                {
                    price = 1.55;
                }
            }

            double total = quantity * price;

            Console.WriteLine(total);
        }
    }
}
