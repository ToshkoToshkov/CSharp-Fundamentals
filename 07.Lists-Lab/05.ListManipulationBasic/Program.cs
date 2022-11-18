namespace ListManipulationBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Add":
                        int numbersToAdd = int.Parse(tokens[1]);
                        nums.Add(numbersToAdd);
                        break;

                    case "Remove":
                        int numbersToRemove = int.Parse(tokens[1]);
                        nums.Remove(numbersToRemove);
                        break;

                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        nums.RemoveAt(indexToRemove);
                        break;

                    case "Insert":
                        int numberToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        nums.Insert(indexToInsert, numberToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
