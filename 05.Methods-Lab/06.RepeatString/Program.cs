using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            RepeatString(text, count);
        }

        private static void RepeatString(string str, int num)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                result.Append(str);
            }

            Console.WriteLine(result.ToString());
        }

    }
}
