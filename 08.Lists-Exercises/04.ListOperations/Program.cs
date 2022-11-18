namespace ListOperations
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

            while (command != "End")
            {
                string[] comArgs = command.Split();
                string firstComm = comArgs[0];

                if (firstComm == "Add")
                {
                    int element = int.Parse(comArgs[1]);
                    nums.Add(element);
                }
                else if (firstComm == "Insert")
                {
                    int element = int.Parse(comArgs[1]);
                    int index = int.Parse(comArgs[2]);

                    if (IsValidIndex(index, nums.Count))
                    {
                        Console.WriteLine("invalid index");
                    }
                    else
                    {
                        nums.Insert(index, element);
                    }
                }
                else if (firstComm == "Remove")
                {
                    int index = int.Parse(comArgs[1]);

                    if (IsValidIndex(index, nums.Count))
                    {
                        Console.WriteLine("invalid index");
                    }
                    else
                    {
                        nums.RemoveAt(index);
                    }
                }
                else if (firstComm == "Shift")
                {
                    int rotation = int.Parse(comArgs[2]);

                    if (comArgs[1] == "left")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int firstElements = nums[0];
                            for (int j = 0; j < nums.Count - 1; j++)
                            {
                                nums[j] = nums[j + 1];
                            }
                            nums[nums.Count - 1] = firstElements;
                        }
                    }
                    else if (comArgs[1] == "right")
                    {
                        for (int i = 0; i < rotation; i++)
                        {
                            int lastElement = nums[nums.Count - 1];

                            for (int j = nums.Count - 1; j > 0; j--)
                            {
                                nums[j] = nums[j - 1];
                            }
                            nums[0] = lastElement;
                        }
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", nums));
        }

        public static bool IsValidIndex(int index, int count)
        {
            return index > count || index < 0;
        }
    }
}
