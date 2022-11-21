using System;
using System.Linq;
using System.Text;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder newRawPAssword = new StringBuilder();

            string command = Console.ReadLine();


            while (command != "Done")
            {
                string[] tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = tokens[0];

                switch (cmd)
                {
                    case "TakeOdd":
                        char[] chars = input.ToCharArray();

                        for (int i = 1; i < input.Length; i += 2)
                        {
                            newRawPAssword.Append(input[i]);
                        }
                        input = newRawPAssword.ToString();
                        Console.WriteLine(input);

                        break;

                    case "Cut":

                        int index = int.Parse(tokens[1]);
                        int lenght = int.Parse(tokens[2]);

                        input = input.Remove(index, lenght);
                        Console.WriteLine(input);


                        break;

                    case "Substitute":
                        string substring = tokens[1];
                        string substitute = tokens[2];

                        if (input.Contains(substring))
                        {
                            input = input.Replace(substring, substitute);
                            Console.WriteLine(input);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }

                        break;
                }
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}
