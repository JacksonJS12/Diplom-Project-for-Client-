using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            double penalty = 0;

            for (int i = 1; i <= n; i++)
            {
                string site = Console.ReadLine();

                if (site == "Facebook") //150
                {
                    penalty += 150;
                }
                else if (site == "Instagram") //100
                {
                    penalty += 100;
                }
                else if (site == "Reddit") //50
                {
                    penalty += 50;
                }
                if (penalty >= salary)
                {
                    break;
                }

            }
            if (penalty >= salary)
            {

                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(salary - penalty);
            }
        }
    }
}
