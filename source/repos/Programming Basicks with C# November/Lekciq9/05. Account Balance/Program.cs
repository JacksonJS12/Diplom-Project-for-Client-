﻿    using System;

    namespace _05._Account_Balance
    {
        class Program
        {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double bankAccount = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);
                if( amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                bankAccount += amount;
                Console.WriteLine($"Increase: {amount:F2}");

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {bankAccount:F2}");
        }
        }
    }
