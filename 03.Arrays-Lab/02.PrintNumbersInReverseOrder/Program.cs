namespace PrintNumbersInReversOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                int currentNum = int.Parse(Console.ReadLine());
                number[i] = currentNum;
            }

            for (int i = number.Length - 1; i >= 0; i--)
            {
                Console.Write(number[i] + " ");
            }
        }
    }
}
