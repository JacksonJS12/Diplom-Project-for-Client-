using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             да прочетем 3 реда от конзолата и да ги запазим в 3 променливи
            */
            double depositSum = double.Parse(Console.ReadLine());
             int mounts = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());


            /*
            изчисление - да намерим сумата
            1. Изчисляваме натрупаната лихва: 200 * 0.057 (5.7%) = 11.40 лв.
            2. Изчисляваме лихвата за 1 месец: 11.40 лв. / 12 месеца = 0.95 лв.
            3. Общата сума е: 200 лв. + 3 * 0.95 лв. = 202.85 лв.
             */


            double interest = depositSum * (percent / 100);
           

            double interestPerMouth = interest / 12;
            

            double sum = depositSum + mounts * interestPerMouth;

            // отпечатваме на конзолата
            Console.WriteLine(sum);
            
           
            


        }
    }
}
