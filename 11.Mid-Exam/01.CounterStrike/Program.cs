using System;

namespace CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            int energy = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            int countWins = 0;

            while (command != "End of battle")
            {
                int intCommand = int.Parse(command);

                if (energy < intCommand)
                {
                    Console.WriteLine($"Not enough energy!" +
                        $" Game ends with {countWins}" +
                        $" won battles and {energy} energy");
                    break;
                }

                countWins++;

                if (countWins % 3 == 0)
                {
                    energy += countWins;
                }

                energy -= intCommand;

                command = Console.ReadLine();

            }

            if (command == "End of battle")
            {
                Console.WriteLine($"Won battles: {countWins}. Energy left: {energy}");
            }
        }
    }
}
