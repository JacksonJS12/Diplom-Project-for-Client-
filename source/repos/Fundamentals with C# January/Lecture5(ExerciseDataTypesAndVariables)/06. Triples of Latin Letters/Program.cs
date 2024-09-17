using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lettersCount = int.Parse(Console.ReadLine()) + 'a';

            for (char i = 'a'; i < lettersCount; i++)
            {
                for (char j = 'a'; j < lettersCount; j++)
                {
                    for (char k = 'a'; k < lettersCount; k++)
                    {
                        string lettersString = "" + i + j + k;
                        Console.WriteLine(lettersString);
                    }
                }
            }
        }
    }
}
