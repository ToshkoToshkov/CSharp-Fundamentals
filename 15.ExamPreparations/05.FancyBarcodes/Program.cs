using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var regexValidBarcode = new Regex(@"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            var numRegex = new Regex(@"\d");

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string str = Console.ReadLine();
                var match = regexValidBarcode.Match(str);

                if (match.Success)
                {
                    string name = match.Groups["barcode"].Value;
                    var digitMatche = numRegex.Matches(name);
                    string productGroup = string.Empty;

                    foreach (Match digit in digitMatche)
                    {
                        if (digit.Success)
                        {
                            productGroup += digit.Value; 
                        }
                    }

                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }

        }
    }
}
