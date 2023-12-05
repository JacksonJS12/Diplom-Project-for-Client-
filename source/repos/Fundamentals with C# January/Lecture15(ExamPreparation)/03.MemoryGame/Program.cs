using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            string command = Console.ReadLine();
            int moveCount = 0;

            while (command != "end")
            {
                moveCount++;
                string[] rawGuessses = command.Split();
                int firstGuess = int.Parse(rawGuessses[0]);
                int secondGuess = int.Parse(rawGuessses[1]);
                    
                if (IsInvalidGuess(firstGuess, secondGuess, elements))
                {
                    int middleOfElemnts = elements.Count / 2;
                    string elemetToAdd = $"-{moveCount}a";
                    elements.Insert(middleOfElemnts, elemetToAdd);
                    elements.Insert(middleOfElemnts, elemetToAdd);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else if (elements[firstGuess] == elements[secondGuess])
                {
                    string guessedElement = elements[firstGuess];
                    elements.Remove(guessedElement);
                    elements.Remove(guessedElement);
                    Console.WriteLine($"Congrats! You have found matching elements - {guessedElement}!");

                }

                else if (elements[firstGuess] != elements[secondGuess])
                {
                    Console.WriteLine("Try again!");
                }

                if (elements.Count == 0)
                {
                    Console.WriteLine($"You have won in {moveCount} turns!");
                    break;
                }

                

                command = Console.ReadLine();
            }

            if (elements.Count > 0)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(String.Join(" ", elements));
            }
        }

        static bool IsInvalidGuess(int firstGuess, int secondGuess, List<string> elements)
        {
            return firstGuess == secondGuess || !IsGuessInList(secondGuess, elements) || !IsGuessInList(firstGuess, elements);
        }

        static bool IsGuessInList(int guess, List<string> elements)
        {
            return guess >= 0 && guess < elements.Count;
        }
    }
}
