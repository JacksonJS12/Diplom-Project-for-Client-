using System;

namespace _02._Film_Premiere
{
    class Program
    {
        static void Main(string[] args)
        {
            int timeForFilming = int.Parse(Console.ReadLine());
            int sceneCount = int.Parse(Console.ReadLine());
            int sceneTime = int.Parse(Console.ReadLine());

            double preparation = timeForFilming * 0.15;
            double totalTimeForScenes = sceneCount * sceneTime;

            double totalTime = preparation + totalTimeForScenes;

            double differance = Math.Round(Math.Abs(timeForFilming - totalTime));
            if (timeForFilming >= totalTime)
            {
                Console.WriteLine($"You managed to finish the movie on time! You have {differance} minutes left!");
            }
            else
            {
                Console.WriteLine($"Time is up! To complete the movie you need {differance} minutes.");
            }
        }
    }
}
