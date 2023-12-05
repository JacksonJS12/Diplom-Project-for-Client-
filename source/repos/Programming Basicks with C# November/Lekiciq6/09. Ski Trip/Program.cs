using System;

namespace _09._Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string rating = Console.ReadLine();

            int nights = days - 1;
            double discount = 0.00;
            double costs = 0.00;
            double total = 0.00;


            // if(type == вид на помещението) 
            // room for one person => nights * 18.00 лв.
            if (type == "room for on    e person")
            {
                costs = nights * 18.00;
                total = costs - costs * discount;
            }

            // apartment => nights * 25.00 лв.
            else if (type == "apartment")
            {
                costs = nights * 25.00;
                // if(days >= 0 && days <= 10) => 30% 
                if (days >= 0 && days <= 10)
                {
                    discount -= costs * 0.30;
                }
                //else if(days <= 15) => 35%
                else if (days <= 15)
                {
                    discount -= costs * 0.35;
                }
                //else => 50%
                else
                {
                    discount -= costs * 0.50;
                }
                //if(rating == "positive") => (costs - costs * discount) + (costs - costs * discount) * 25%
                if (rating == "positive")
                {
                    total -= discount * 0.25;
                }
                //else => (costs - costs * discount) - (costs - costs * discount) * 10%
                else
                {
                    total -= discount * 0.10;
                }
            }

            // president apartment => nights * 35.00 лв.
            else if (type == "president apartment")
            {
                costs = nights * 35.00;
                // if(days >= 0 && days <= 10) => 10%
                if (days >= 0 && days <= 10)
                {
                    discount -= costs * 0.10;
                }
                //else if (days <= 15) => 15%
                else if (days <= 15)
                {
                    discount -= costs * 0.15;
                }
                //else => 20%
                else
                {
                    discount -= costs * 0.20;
                }
                //if(rating == "positive") => (costs - costs * discount) + (costs - costs * discount) * 25%
                if (rating == "positive")
                {
                    total -= discount * 0.25;
                }
                //else => (costs - costs * discount) - (costs - costs * discount) * 10%
                else
                {
                    total -= discount * 0.10;
                }
            }
            

            Console.WriteLine($"{total:F2}");
        }
    }
}
