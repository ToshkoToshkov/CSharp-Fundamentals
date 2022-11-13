namespace CalculateRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = GetRectangleArea(weight, height);
            Console.WriteLine(area);
        }

        static double GetRectangleArea(double weight, double height)
        {
            return weight * height;
        }
    }
}
