using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] currentCommand = command.Split();
                string comm = currentCommand[0];

                if (comm == "Shoot")
                {
                    int index = int.Parse(currentCommand[1]);
                    int power = int.Parse(currentCommand[2]);

                    if (index < 0 || index >= targets.Count)
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    targets[index] -= power;

                    if (targets[index] <= 0)
                    {
                        targets.Remove(targets[index]);
                    }

                }
                else if (comm == "Add")
                {
                    int index = int.Parse(currentCommand[1]);
                    int value = int.Parse(currentCommand[2]);

                    if (index < 0 || index >= targets.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        command = Console.ReadLine();
                        continue;
                    }

                    targets.Insert(index, value);
                }
                else if (comm == "Strike")
                {
                    int index = int.Parse(currentCommand[1]);
                    int radius = int.Parse(currentCommand[2]);

                    int startIndex = index - radius;
                    int endIndex = index + radius;

                    if (startIndex >= 0 && endIndex < targets.Count)
                    {
                        targets.RemoveRange(startIndex, endIndex);
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                        command = Console.ReadLine();
                        continue;
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine(string.Join('|', targets));
            }
        }
    }
}
