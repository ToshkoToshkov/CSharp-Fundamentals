namespace SmallestOfThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallestInt(first, second, third));

        }

        private static int SmallestInt(int first, int second, int third)
        {
            if (first < second && first < third)
            {
                return first;
            }
            else if (second < first && second < third)
            {
                return second;
            }
            else
            {
                return third;
            }
        }
    }
}
