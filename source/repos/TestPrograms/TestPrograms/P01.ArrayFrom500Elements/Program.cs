using System;
using System.Linq;

namespace P01.ArrayOfElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = new string[10];
            for (int i = 0; i < array.Length; i++)
            {
                Random random = new Random();
                array[i] = random.Next(1, 500).ToString();
            }
            Console.WriteLine(String.Join(" ", array));

            Console.WriteLine("Digit count:");
            for (int i = 0; i <= 9; i++)
            {
                int times = 0;
                for (int k = 0; k < array[i].Length; k++)
                {
                    string number = array[i];

                    //number[k] == 1 ||
                    //number[k] == 2 ||
                    //number[k] == 3 ||
                    //number[k] == 4 ||
                    //number[k] == 5 ||
                    //number[k] == 6 ||
                    //number[k] == 7 ||
                    //number[k] == 8 ||
                    //number[k] == 9)

                    if (number[k] == 0)
                    {

                    }
                    else if (number[k] == 1)
                    {

                    }
                    else if(number[k] == 2)
                    {

                    }
                    else if (number[k] == 3)
                    {

                    }
                    else if (number[k] == 4)
                    {

                    }
                    else if (number[k] == 5)
                    {

                    }
                    else if (number[k] == 6)
                    {

                    }
                    else if (number[k] == 7)
                    {

                    }
                    else if (number[k] == 8)
                    {

                    }
                    else if (number[k] == 9)
                    {

                    }

                }
                
            }
        }
    }

}
