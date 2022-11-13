namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double factorialFirstNum = GetFactoriel(first);
            double factorialSecondNum = GetFactoriel(second);

            double result = factorialFirstNum / factorialSecondNum;

            Console.WriteLine($"{result:F2}");
        }

        public static double GetFactoriel(int number)
        {
            double result = 1;
            while (number != 1)
            {
                result = result * number;
                number = number - 1;
            }
            return result;
        }
    }
}
