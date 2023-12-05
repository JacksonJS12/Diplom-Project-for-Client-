using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            //прочитаме от конзолата на отделни редове размерите му – дължина, широчина и височина и % заето простанство
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentOccupiedSpace = double.Parse(Console.ReadLine());

            //пресмятаме колко литра вода ще събира аквариума (v на аквариума - определен процент от вместимостта му, която е заета от пясък, растения, нагревател и помпа. 
            double volumeOfFishTank = (length * width * height);
            double litersForFilling = volumeOfFishTank / 1000;
            double finalLitersForFilling = litersForFilling * (1 -(percentOccupiedSpace/100));

            //отпечатваме резултатът в конзолата
            Console.WriteLine(finalLitersForFilling);




        }
    }
}
