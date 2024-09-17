﻿using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string assessorName = Console.ReadLine();
                double points = double.Parse(Console.ReadLine());

                academyPoints += (assessorName.Length * points / 2) ;

                if (academyPoints >= 1250.5)
                {
                    break;
                }

            }

            if (academyPoints >= 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {academyPoints:F1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.5 - academyPoints:F1} more!");
            }
        }
    }
}
