using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string typeOfTheGroup = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0.0;

            switch (typeOfTheGroup)
            {
                case "Students":

                    if (day == "Friday")
                    {
                        price = numOfPeople * 8.45;

                        if (numOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Saturday")
                    {
                        price = numOfPeople * 9.80;

                        if (numOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Sunday")
                    {
                        price = numOfPeople * 10.46;

                        if (numOfPeople >= 30)
                        {
                            price = price - (price * 0.15);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }


                    break;

                case "Business":

                    if (day == "Friday")
                    {
                        price = numOfPeople * 10.90;

                        if (numOfPeople >= 100)
                        {
                            price = price - (10 * 10.90);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Saturday")
                    {
                        price = numOfPeople * 15.60;

                        if (numOfPeople >= 100)
                        {
                            price = price - (10 * 15.60);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Sunday")
                    {
                        price = numOfPeople * 16;

                        if (numOfPeople >= 100)
                        {
                            price = price - (10 * 16);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }

                    break;

                case "Regular":

                    if (day == "Friday")
                    {
                        price = numOfPeople * 15;

                        if (numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            price = price - (price * 0.05);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Saturday")
                    {
                        price = numOfPeople * 20;

                        if (numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            price = price - (price * 0.05);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }
                    else if (day == "Sunday")
                    {
                        price = numOfPeople * 22.50;

                        if (numOfPeople >= 10 && numOfPeople <= 20)
                        {
                            price = price - (price * 0.05);
                        }

                        Console.WriteLine($"Total price: {price:F2}");
                    }

                    break;
            }
        }
    }
}
