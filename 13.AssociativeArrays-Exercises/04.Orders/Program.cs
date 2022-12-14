namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            string input = Console.ReadLine();

            while (input != "buy")
            {
                string[] currentProduct = input.Split();
                string productName = currentProduct[0];
                double productPrice = double.Parse(currentProduct[1]);
                double quantity = double.Parse(currentProduct[2]);

                if (!output.ContainsKey(productName))
                {
                    List<double> priceAndQuantity = new List<double> { productPrice, quantity };
                    output.Add(productName, priceAndQuantity);
                }
                else
                {
                    output[productName][0] = productPrice;
                    output[productName][1] += quantity;
                }

                input = Console.ReadLine();
            }

            foreach (var item in output)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");
            }
        }
    }
}
