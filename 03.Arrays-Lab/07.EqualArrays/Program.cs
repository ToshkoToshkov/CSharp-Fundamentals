namespace EqualArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] secondArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sum = 0;

            for (int i = 0; i < firstArr.Length; i++)
            {

                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                else
                {
                    for (int j = 0; j < firstArr.Length; j++)
                    {
                        sum += firstArr[j];   
                    }
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    break;
                }
            }
           
        }
    }
}
