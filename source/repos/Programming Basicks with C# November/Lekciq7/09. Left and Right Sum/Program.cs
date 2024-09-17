using System;

namespace _09._Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) * 2;

            if (n == 4)
            { 
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            int num1Sum = num1 + num2;
            int num2Sum = num3 + num4;


                for (int i = 0; i < 1; i++)
                {

                    if (num1Sum == num2Sum)
                    {
                        Console.WriteLine($" Yes, sum = {num1Sum}");
                    }
                    else
                    {
                        int difference = num1Sum - num2Sum;

                        Console.WriteLine($" No, diff = {difference = Math.Abs(difference)}");
                    }

                }

            }

        }
    }
}
