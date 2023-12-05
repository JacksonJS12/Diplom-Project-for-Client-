using System;

namespace _03._Cat_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string specie = Console.ReadLine();
            char gender = char.Parse(Console.ReadLine());

            int humanYears = 0;

            if (gender == 'm')
            {
                switch (specie)
                {
                    case "British Shorthair":
                        humanYears = 13;
                        break;
                    case "Siamese":
                        humanYears = 15;
                        break;
                    case "Persian":
                        humanYears = 14;
                        break;
                    case "Ragdoll":
                        humanYears = 16;
                        break;
                    case "American Shorthair":
                        humanYears = 12;
                        break;
                    case "Siberian":
                        humanYears = 11;
                        break;
                    default:
                        Console.WriteLine($"{specie} is invalid cat!");
                        break;

                }
            }
            else if (gender == 'f')
            {
                switch (specie)
                {
                    case "British Shorthair":
                        humanYears = 14;
                        break;
                    case "Siamese":
                        humanYears = 16;
                        break;
                    case "Persian":
                        humanYears = 15;
                        break;
                    case "Ragdoll":
                        humanYears = 17;
                        break;
                    case "American Shorthair":
                        humanYears = 13;
                        break;
                    case "Siberian":
                        humanYears = 12;
                        break;
                    default:
                        Console.WriteLine($"{specie} is invalid cat!");
                        break;
                }
            }
           

            int humanMounts = humanYears * 12;
            double catMounts = humanMounts / 6;

            if (catMounts != 0)
            {
            Console.WriteLine($"{Math.Round(catMounts)} cat months");

            }
        }
    }
}
