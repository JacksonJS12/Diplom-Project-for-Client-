using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            int sum = 0;
            int num = 0;

            while (input != 0)
            {
                
                num = input % 10;
                input /= 10;
                sum += num;
            }

            Console.WriteLine(sum);
        }
    }
}
