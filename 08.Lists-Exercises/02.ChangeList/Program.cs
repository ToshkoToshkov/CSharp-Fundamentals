namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] comArr = command.Split();

                string firstCommand = comArr[0];
                int element = int.Parse(comArr[1]);

                if (firstCommand == "Delete")
                {
                    nums.RemoveAll(x => x == element);
                }
                else if (firstCommand == "Insert")
                {
                    int indexer = int.Parse(comArr[2]);
                    nums.Insert(indexer, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
