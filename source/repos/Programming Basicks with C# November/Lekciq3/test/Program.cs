using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade >= 5.50 & grade <= 6.00)


            {
                Console.WriteLine("Excellent!");
            }
            if (grade <= 5.49)
            {
                Console.WriteLine("Try again!");
            }

           else if (grade <= 1.99 & grade >= 6.01)
            {
                Console.WriteLine("Invalid grade!");
            
        }

    }
}
}
