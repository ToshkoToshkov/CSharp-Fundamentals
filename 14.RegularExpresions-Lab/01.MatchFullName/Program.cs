using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ \b[A-Z][a-z]+";
            string text = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(text, pattern);

            foreach (Match name in matchedNames)
            {
                Console.Write(name.Value + " ");
            }

            Console.WriteLine();
        }
    }
}
