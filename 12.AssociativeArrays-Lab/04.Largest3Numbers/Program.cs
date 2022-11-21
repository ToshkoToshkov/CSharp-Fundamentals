int[] input = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int[] sortedNumbers = input.OrderByDescending(n => n).ToArray();

for (int i = 0; i < 3; i++)
{
    Console.Write(sortedNumbers[i] + " ");
}

