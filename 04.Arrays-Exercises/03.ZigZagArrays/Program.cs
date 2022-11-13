namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] firstArr = new string[n];
            string[] secondArr = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine()
                    .Split()
                    .ToArray();

                string indexZeroElement = currentArray[0];
                string indexFirstElement = currentArray[1];

                if (i % 2 == 0)
                {
                    firstArr[i] = indexZeroElement;
                    secondArr[i] = indexFirstElement;
                }
                else if (i % 2 == 1)
                {
                    firstArr[i] = indexFirstElement;
                    secondArr[i] = indexZeroElement;
                }
            }

            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
