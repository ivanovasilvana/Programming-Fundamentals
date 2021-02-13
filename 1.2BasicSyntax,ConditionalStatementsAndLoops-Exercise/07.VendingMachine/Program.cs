using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sum = 0;
            double price = 0;

            while (input != "Start")
            {
                double money = double.Parse(input);
                if (money != 0.1 && money != 0.2 && money != 0.5 && money != 1 && money != 2  )
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                else
                {
                    sum += money;
                }
                input = Console.ReadLine();
            }
            string inputTwo = Console.ReadLine();

            while (inputTwo != "End")
            {
                if (inputTwo != "Nuts" && inputTwo != "Water" && inputTwo != "Crisps" && inputTwo != "Soda" && inputTwo != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                else
                {
                    if (inputTwo == "Nuts")
                    {
                        price += 2;
                    }
                    else if (inputTwo == "Water" )
                    {
                        price += 0.7;
                    }
                    else if (inputTwo == "Crisps")
                    {
                        price += 1.5;
                    }
                    else if (inputTwo == "Soda")
                    {
                        price += 0.8;
                    }
                    else if (inputTwo == "Coke")
                    {
                        price += 1;
                    }
                    if (price <= sum)
                    {
                        string newString = inputTwo.ToLower();
                        Console.WriteLine($"Purchased {newString}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        break;
                    }
                }
                inputTwo = Console.ReadLine();
            }
            double moneyLeft = Math.Abs(sum - price);
            Console.WriteLine($"Change: {moneyLeft:f2}");
        }
    }
}
