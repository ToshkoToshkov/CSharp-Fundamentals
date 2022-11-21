using System;
using System.Collections.Generic;
using System.Linq;

namespace ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> initialList = Console.ReadLine()
                .Split('!')
                .ToList();

            string command = Console.ReadLine();

            while (command != "Go Shopping!")
            {
                string[] commArray = command.Split();

                string comm = commArray[0];
                string item = commArray[1];

                if (comm == "Urgent")
                {
                    if (!initialList.Contains(item))
                    {
                        initialList.Insert(0, item);
                    }
                }
                else if (comm == "Unnecessary")
                {
                    initialList.Remove(item);
                }
                else if (comm == "Correct")
                {
                    string newItem = commArray[2];

                    if (initialList.Contains(item))
                    {
                        int index = initialList.FindIndex(x => x == item);
                        initialList.RemoveAt(index);
                        initialList.Insert(index, newItem);
                    }
                }
                else if (comm == "Rearrange")
                {
                    if (initialList.Contains(item))
                    {
                        initialList.Remove(item);
                        initialList.Add(item);
                    }
                }

                command = Console.ReadLine();
            }

            if (command == "Go Shopping!")
            {
                Console.WriteLine(string.Join(", ", initialList));
            }
        }
    }
}
