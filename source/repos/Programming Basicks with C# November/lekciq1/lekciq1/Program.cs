using System;

namespace lekciq1
{
    class Program
    {
        static void Main()
        {
            double S = double.Parse(Console.ReadLine());

            double c = S * 21.22;
            double percent = 0.18 * c;

            double kc = c - percent;

            Console.WriteLine("The final price is: " + kc + " lv.");
            Console.WriteLine("The discount is: " + percent + " lv.");










        }
    }
}
