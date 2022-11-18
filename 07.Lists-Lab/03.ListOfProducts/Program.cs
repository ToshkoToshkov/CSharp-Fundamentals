﻿namespace ListOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> result = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string currentProduct = Console.ReadLine();
                result.Add(currentProduct);
            }

            result.Sort();

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{result[i]}");
            }
        }
    }
}
