namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            PrintCharInRange(first, second);
        }

        private static void PrintCharInRange(char first, char second)
        {
            if (first > second)
            {
                char firstChar = first;
                first = second;
                second = firstChar;
            }

            for (int i = first + 1; i < second; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
