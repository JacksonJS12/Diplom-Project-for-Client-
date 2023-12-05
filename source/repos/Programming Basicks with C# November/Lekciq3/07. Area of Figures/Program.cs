using System;

namespace _07._Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            /*
            double square = a * a;
            double rectangle = a * b;
            double circle = a * a * Math.PI;
            double triangle = a * b / 2;
            */


            if (type == "square") 
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a);
            }

            else if (type == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b);
            }

            else if (type == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(a*a*Math.PI);
            }

            else if (type == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(a*b/2);
            }

        }
    }
}
