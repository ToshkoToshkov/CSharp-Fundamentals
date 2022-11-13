namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second, third);
            Console.WriteLine(sum);
        }


        private static int Sum(int first, int second, int third)
        {
            int result = first + second;
            return Subtract(result, third);
        }

        private static int Subtract(int result, int third)
        {
            return result - third;
        }
    }
}
