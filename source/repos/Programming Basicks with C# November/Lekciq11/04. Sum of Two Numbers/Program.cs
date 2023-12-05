using System;

namespace _04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCounter = 0;

            for (int a = start; a <= end; a++)
            {
                for (int b = start; b <= end; b++)
                {
                    combinationCounter++;
                    int sum = a + b;

                    if(sum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCounter} ({a} + {b} = {magicNum})");
                        return;
                    }
                    
                }
            }
            Console.WriteLine($"{combinationCounter} combinations - neither equals {magicNum}");
        }
    }
}
