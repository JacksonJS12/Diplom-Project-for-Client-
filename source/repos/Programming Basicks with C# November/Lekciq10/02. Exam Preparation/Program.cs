using System;

namespace _02._Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int failedTimes = int.Parse(Console.ReadLine());

            int evaluation = 0;

            double evaluationCount = 0;
            int evaluationSum = 0;

            string lastExercise = "";
            int failedCount = 0;

            string input = Console.ReadLine();
            while (input != "Enough")
            {
                lastExercise = input;
                evaluation = int.Parse(Console.ReadLine());

                evaluationSum += evaluation;
                evaluationCount++;

                if (evaluation <= 4)
                {
                    failedCount++;
                    if (failedTimes == failedCount)
                    {
                        break;
                    }

                }
                //o	"Average score: {средна оценка}"
                //  "Number of problems: {броя на всички задачи}"
                //o   "Last problem: {името на последната задача}"
                //•	Ако получи определеният брой незадоволителни оценки:
                //o   "You need a break, {брой незадоволителни оценки} poor grades."

                input = Console.ReadLine();
            }
            if (input == "Enough")
            {
                Console.WriteLine($"Average score: {evaluationSum/evaluationCount:F2}");
                Console.WriteLine($"Number of problems: {evaluationCount}");
                Console.WriteLine($"Last problem: {lastExercise}");

            }
            else
            {
                Console.WriteLine($"You need a break, {failedCount} poor grades.");
            }
        }
    }
}
