namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int currentNumber = nums[i];

                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else
                {
                    sumOdd += currentNumber;
                }
            }

            int result = sumEven - sumOdd;

            Console.WriteLine(result);

        }
    }
}
