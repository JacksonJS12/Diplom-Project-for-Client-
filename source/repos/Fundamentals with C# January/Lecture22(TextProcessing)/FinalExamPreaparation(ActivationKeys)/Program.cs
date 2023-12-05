using System;

namespace FinalExamPreaparation_ActivationKeys_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rawActiovationKey = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Generate")
            {
                string[] commandParams = command
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);

                string action = commandParams[0];

                if (action == "Contains")
                {
                    string wordToSearchFor = commandParams[1];

                    if (rawActiovationKey.Contains(wordToSearchFor))
                    {
                        Console.WriteLine($"{rawActiovationKey} contains {wordToSearchFor}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (action == "Flip")
                {
                    string caseToFlip = commandParams[1];
                    int startIndex = int.Parse(commandParams[2]);
                    int endIndex = int.Parse(commandParams[3]);

                    string textToFlip = rawActiovationKey.Substring(startIndex, endIndex - startIndex);

                    if (caseToFlip == "Lower")
                    {
                        textToFlip = textToFlip.ToLower();
                    }
                    else
                    {
                        textToFlip = textToFlip.ToUpper();
                    }

                    rawActiovationKey = rawActiovationKey.Remove(startIndex, endIndex - startIndex);
                    rawActiovationKey = rawActiovationKey.Insert(startIndex, textToFlip);
                    Console.WriteLine(rawActiovationKey);
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(commandParams[1]);
                    int endIndex = int.Parse(commandParams[2]);

                    rawActiovationKey = rawActiovationKey.Remove(startIndex, endIndex - startIndex);

                    Console.WriteLine(rawActiovationKey);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawActiovationKey}");
        }
    }
}
