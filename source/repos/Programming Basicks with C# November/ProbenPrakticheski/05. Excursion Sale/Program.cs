using System;

namespace _05._Excursion_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            int seaExcursionCount = int.Parse(Console.ReadLine());
            int mountainExcursionCount = int.Parse(Console.ReadLine());

            int profit = 0;
            string package = Console.ReadLine();
         

            while (package != "Stop")
            {

                if (package == "sea")
                {
                   
                    if (seaExcursionCount > 0)
                    {
                        profit += 680;
                        seaExcursionCount--;
                    }

                }
                else if (package == "mountain")
                {

                    if (mountainExcursionCount > 0)
                    {
                        profit += 499;
                        mountainExcursionCount--;
                    }
                }
                if ( seaExcursionCount == 0 && mountainExcursionCount == 0)
                {
                    Console.WriteLine(" Good job! Everything is sold.");
                    break;
                }

                package = Console.ReadLine();
            }

            Console.WriteLine($"{profit}");
        }
    }
}
