﻿using System;

namespace _06._Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int floor = floors; floor > 0; floor--)
            {
                for (int room = 0; room < rooms; room++)
                {
                    if(floor == floors)
                    {
                        Console.Write($"L{floor}{room} ");
                        continue;
                    }

                    if(floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{room} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{room} ");
                    }
                    
                
                }
                Console.WriteLine();
            }

        }
    }
}
