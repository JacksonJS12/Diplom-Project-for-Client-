using System;

namespace _12._Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;
            bool isValid = true;

            if (city == "Sofia")
            {
                if (sales > 0 && sales <= 500 && sales != 0)
                {
                    commission = sales * 0.05;
                }
                else if (sales > 500 && sales <= 1000 && sales != 0)
                {
                    commission = sales * 0.07;
                }
                else if (sales > 1000 && sales <= 10000 && sales != 0)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 10000 && sales != 0)
                    commission = sales * 0.12;
                else
                {
                    isValid = false;
                    Console.WriteLine("error");
                }


            }
            else if (city == "Varna")
            {
                if (sales > 0 && sales <= 500 && sales != 0)
                {
                    commission = sales * 0.045;
                }
                else if (sales > 500 && sales <= 1000 && sales != 0)
                {
                    commission = sales * 0.075;
                }
                else if (sales > 1000 && sales <= 10000 && sales != 0)
                {
                    commission = sales * 0.1;
                }
                else if (sales > 10000 && sales != 0)
                    commission = sales * 0.13;
                else
                {
                    isValid = false;
                    Console.WriteLine("error");
                }


            }
            else if (city == "Plovdiv")
            {
                if (sales > 0 && sales <= 500 && sales != 0)
                {
                    commission = sales * 0.055;
                }
                else if (sales > 500 && sales <= 1000 && sales != 0)
                {
                    commission = sales * 0.08;
                }
                else if (sales > 1000 && sales <= 10000 && sales != 0)
                {
                    commission = sales * 0.12;
                }
                else if (sales > 10000 && sales != 0)
                    commission = sales * 0.145;
                else
                {
                    isValid = false;
                    Console.WriteLine("error");
                }


            }
            else
            {
                isValid = false;
                Console.WriteLine("error");
            }
            if (isValid)
            {
                Console.WriteLine($"{commission:F2}");
            }
        }

    }
}
