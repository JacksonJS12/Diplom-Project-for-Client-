using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int numInNumber = 1; numInNumber <= number; numInNumber++)
            {

                if (IsDivisibleBy8(numInNumber) != IsHoldAtLeastOneOddDigit(numInNumber))
                {
                    Console.WriteLine(numInNumber);
                }


            }


        }


        static int SumOfDigits(int number)
        {
            int sum = 0;
            for (int digit = 1; digit <= number; digit++)
            {
                sum += number;
            }

            return sum;
        }
        static int IsDivisibleBy8(int number)
        {
            int sum = SumOfDigits(number);


            if (sum % 8 == 0)
            {
                return number;
            }
            else
            {
                return 0;
            }
            
        }

        static int IsHoldAtLeastOneOddDigit(int number)
        {
            int sumOfDigits = SumOfDigits(number);
            while (sumOfDigits > 0)
            {
                if ((sumOfDigits % 10) % 2 == 1)
                    return number;
                sumOfDigits /= 10;
            }

            return 0;
        }
    }
}
