using System;
using System.Linq;

namespace _02.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            int shootCount = 0;

            while (command != "End")
            {
                int indexToShoot = int.Parse(command);

                if (indexToShoot >= 0
                    && indexToShoot < targets.Length
                    && targets[indexToShoot] != -1)
                {
                    ShootTarget(indexToShoot, targets);
                    shootCount++;
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Shot targets: {shootCount} -> {string.Join(" ", targets)}");
        }

        static void ShootTarget(int shootIndex, int[] targets)
        {
            var valueOfTarget = targets[shootIndex];

            targets[shootIndex] = -1;

            for (int i = 0; i < targets.Length; i++)
            {
                if (targets[i] == -1)
                {
                    continue;
                }
                if (targets[i] > valueOfTarget)
                {
                    targets[i] -= valueOfTarget;
                }
                else
                {
                    targets[i] += valueOfTarget;
                }
            }

        }
    }
}
