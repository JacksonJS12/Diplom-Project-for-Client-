using System;

namespace _02._Equal_Sums_Even_Odd_Position
{
    class Program
    {
        static void Main(string[] args)
        {

            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            int oddSum;
            int evenSum;
            string currentNum;

            for (int i = first; i <= second; i++)
            {
                oddSum = 0;
                evenSum = 0;

                currentNum = i.ToString();

                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        evenSum += currentNum[j];
                    }
                    else
                    {
                        oddSum += currentNum[j];
                        ;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(currentNum + " ");

                }
            }
        }
    }
}
