using System;

namespace VacationBooksList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int numberOfDays = int.Parse(Console.ReadLine());

            int numberOfHoursPerBook = numberOfPages / pagesPerHour;
            int nuberOfHoursPerDay = numberOfHoursPerBook / numberOfDays;

            Console.WriteLine(nuberOfHoursPerDay);



        }
    }
}
