using System;

namespace PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int final = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = start; i <= final; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }

            int totalSum = sum;

            Console.WriteLine("");
            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
