namespace CountCharsInAStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToCharArray();

            Dictionary<char, int> occurrences = new Dictionary<char, int>();

            foreach (var item in input)
            {
                if (item != ' ')
                {
                    if (!occurrences.ContainsKey(item))
                    {
                        occurrences.Add(item, 0);
                    }
                    occurrences[item]++;
                }
            }

            foreach (var item in occurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
