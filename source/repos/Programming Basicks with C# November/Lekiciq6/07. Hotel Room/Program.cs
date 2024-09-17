using System;

namespace _07._Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            // Май и Октомври 
            // Студио - 50 => (nights <=7 && nights < 14) = 5%, (nights >= 14) = 30%
            // Апартамент - 65  (nights >= 14) = 10%



            // Юни и Септември 
            // Студио - 75.20 => (nights >= 14) = 20%
            // Апартамент - 68.70 => (nights >= 14) = 10%


            // Юли и Август 
            // Студио - 76
            // Апартамент - 77 => (nights >= 14) = 10%

            string mounth = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());

            double StudiotPrice = nights;
            double apartmentPrice = nights;

            if (mounth == "May" || mounth == "October")
            {
                StudiotPrice = nights * 50;
                apartmentPrice = nights * 65;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                    StudiotPrice -= StudiotPrice * 0.30;
                }
                else if(nights > 7)
                {
                    StudiotPrice -= StudiotPrice * 0.05;
                }
            }
            else if (mounth == "June" || mounth == "September")
            {
                StudiotPrice = nights * 75.20;
                apartmentPrice = nights * 68.70;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                    StudiotPrice -= StudiotPrice * 0.20;
                }
                
            }
            else if (mounth == "July" || mounth == "August")
            {
                StudiotPrice = nights * 76;
                apartmentPrice = nights * 77;
                if (nights > 14)
                {
                    apartmentPrice -= apartmentPrice * 0.10;
                   
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:F2} lv.");
            Console.WriteLine($"Studio: {StudiotPrice:F2} lv.");
            
        }
    }   
}
