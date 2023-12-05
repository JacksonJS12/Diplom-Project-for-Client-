using System;

namespace _03._Sum_Prime_Non_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num;
            int primeSum = 0;
            int nonPrimeSum = 0;

            bool isPraim;

            while (input != "stop")
            {
                num = int.Parse(Console.ReadLine());
                isPraim = true;

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPraim = false;
                            nonPrimeSum =nonPrimeSum + num;
                            break;
                        }
                    }
                    if (isPraim)
                    {
                        primeSum = primeSum + num;
                    }
                }
               input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}


