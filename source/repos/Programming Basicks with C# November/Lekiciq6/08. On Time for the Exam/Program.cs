using System;

namespace _08._On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int testHour = int.Parse(Console.ReadLine());
            int testMin = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            int minLate = arrivalMin - testMin;
            int hourLate = arrivalHour - testMin;

            int minBefore = testMin - arrivalMin;
            int hourBefore = testHour - arrivalHour;

            if (arrivalMin >= 0 && arrivalMin <= 59 && arrivalHour >= 0 && arrivalHour <= 23)
            {
                if (arrivalMin >= testMin - 30 && arrivalMin < testMin && testHour == arrivalHour)
                {
                    Console.WriteLine("On time");
                    if (minBefore < 10)
                    {
                        if (hourBefore == 24)
                        {
                            hourBefore = 0;
                        }
                        Console.WriteLine($"{hourBefore}:0{minBefore} hours before the start");
                    }
                    else
                    {
                        if (hourBefore == 24)
                        {
                            hourBefore = 0;
                        }

                        Console.WriteLine($"{hourBefore}:{minBefore} hours before the start");
                    }
                }
                else if (arrivalMin > testMin || arrivalHour >= testHour)
                {
                    Console.WriteLine("Late");
                    if (arrivalMin < testMin + 59)
                    {
                        Console.WriteLine($"{minLate} minutes after the start");
                    }
                    else
                    {
                        if (minLate < 10)
                        {
                            if (hourLate == 24)
                            {
                                hourLate = 0;
                            }
                            Console.WriteLine($"{hourLate}:0{minLate} hours after the start");
                        }
                        else
                        {
                            if (hourLate == 24)
                            {
                                hourLate = 0;
                            }

                            Console.WriteLine($"{hourLate}:{minLate} hours after the start");
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Early");
                    if (minBefore < 10)
                    {
                        if (hourBefore == 24)
                        {
                            hourBefore = 0;
                        }
                        Console.WriteLine($"{hourBefore}:0{minBefore} hours before the start");
                    }
                    else
                    {
                        if (hourBefore == 24)
                        {
                            hourBefore = 0;
                        }

                        Console.WriteLine($"{hourBefore}:{minBefore} hours before the start");
                    }
                }

            }

        }
    }
}
