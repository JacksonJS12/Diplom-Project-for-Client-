using System;

namespace _06.Multiplication_table
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            int d = 0;
            int e = 0;

            e = n % 10;
            n  = n / 10; //=> 32
            d = n % 10;
            s = n / 10; //s => 3, d=> 2, e => 4

            for (int i = 1; i <= e; i++)
            {
                for (int j = 1; j <= d; j++)
                {
                    for (int k = 1; k <= s; k++)
                    {
                        int multiple = i * j * k;
                        Console.WriteLine($"{i}*{j}*{k} = {multiple}");
                    }
                }
            }


        }
    }
}
