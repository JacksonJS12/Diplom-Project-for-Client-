using System;

namespace _08.Cinema_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();

            double price = 0;

            /* switch (day)
             {
                 case "Monday":
                 case "Tuesday":
                 case "Friday":
                     price = 12;
                     break;
                 case "Wednesday":
                 case "Thursday":
                     price = 14;
                     break;
                 case "Saturday":
                 case "Sunday":
                     price = 16;
                     break;
             }
            */

            if (day == "Monday" || day == "Tuesday" || day == "Friday")
            {
                price = 12;
            }
            else if (day == "Wednesday" || day == "Thursday")
            {
                price = 14;
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                price = 16;
            }

            Console.WriteLine(price);
        }
    }
}
