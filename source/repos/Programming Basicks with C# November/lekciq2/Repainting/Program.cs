using System;

namespace Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем 4-ри реда пт конзолата (3 материала + часове за работа)
            int nylonQuantily = int.Parse(Console.ReadLine());
            int paintQuantily = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workersHours = int.Parse(Console.ReadLine());
            //изчисляваме сумата на всеки един от материалите (общо 3)
            double nylonPrice = (nylonQuantily + 2) * 1.5;
            double paintPrice = (paintQuantily + paintQuantily * 0.1) * 14.50;
            double thinnerPrice = thinnerLiters * 5.00;
            //изчисляваме  разходи за материали (общо 3 + цена за торбичка)
            double materialSum = nylonPrice + paintPrice + thinnerPrice + 0.40;
            //заплатата на майстора (часове * 30% от разходи за материали)
            double workersSum = (materialSum * 0.3) * workersHours;


            //общо сумата от всички рзходи (заплатата на майстора +  разходи за материали)
            double totalSum = materialSum + workersSum;

            //отпечатваме общата сума от всички разходи
            Console.WriteLine(totalSum);

        }
    }
}