using System;

namespace _03._Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int timeInMin = (hours * 60) + minutes + 15;
            int hours1 = timeInMin / 60;
            int minutes1 = timeInMin % 60;

           
                
            if (minutes1 < 10 )
            {
                if (hours1 == 24)
                {
                    hours1 = 0;
                }
                Console.WriteLine($"{hours1}:0{minutes1}");
            }
            else
            {
                if (hours1 == 24)
                {
                    hours1 = 0;
                } 

                Console.WriteLine($"{hours1}:{minutes1}");
            }
                
            

            

           
            
        }
    }
}
