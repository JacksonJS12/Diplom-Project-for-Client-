using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double availbleMoney = double.Parse(Console.ReadLine());

            int count = 0;
            int spendCount = 0;

            string input = ""; //SPEND OR SAIVED
            double money = 0;
            while (availbleMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());

                count++;

                if (input == "spend")
                {
                    spendCount++;
                    availbleMoney -= money;
                    if (availbleMoney < 0)
                    {
                        availbleMoney = 0;
                    }
                    if (spendCount == 5)
                    {
                        break;
                    }
                }
                else
                {
                    availbleMoney += money;
                    spendCount = 0;
                }
               
            }
            if (spendCount == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(count);
            }
            else
            {
                Console.WriteLine($"You saved the money for {count} days.");
            }
        }
    }
}
