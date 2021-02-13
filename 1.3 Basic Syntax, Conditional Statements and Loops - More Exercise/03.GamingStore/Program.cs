using System;

namespace _03.GamingStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double startBalance = double.Parse(Console.ReadLine());
            double balance = startBalance;
            double moneySpent = 0;
            while (true)
            {
                string input = Console.ReadLine();
                if (input != "OutFall 4" && input != "CS: OG" && input != "Zplinter Zell" && input != "Honored 2" && input != "RoverWatch" && input != "RoverWatch Origins Edition" && input != "Game Time")
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    if (input == "OutFall 4" || input == "RoverWatch Origins Edition")
                    {
                        if (balance < 39.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            moneySpent += 39.99;
                            balance -= 39.99;
                            Console.WriteLine($"Bought {input}");
                        }
                    }
                    else if (input == "CS: OG")
                    {
                        if (balance < 15.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            moneySpent += 15.99;
                           balance -= 15.99;
                            Console.WriteLine($"Bought {input}");
                        }
                    }
                    else if (input == "Zplinter Zell")
                    {
                        if (balance < 19.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            moneySpent += 19.99;
                           balance -= 19.99;
                            Console.WriteLine($"Bought {input}");
                        }
                    }
                    else if (input == "Honored 2")
                    {
                        if (balance < 59.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            moneySpent += 59.99;
                           balance -= 59.99;
                            Console.WriteLine($"Bought {input}");
                        }
                    }
                    else if (input == "RoverWatch")
                    {
                        if (balance < 29.99)
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            moneySpent += 29.99;
                           balance -= 29.99;
                            Console.WriteLine($"Bought {input}");
                        }
                    }
                    if (balance <= 0)
                    {
                        input = Console.ReadLine();
                        Console.WriteLine("Out of money!");
                        break;
                    }
                    if (input == "Game Time")
                    {
                        Console.WriteLine($"Total spent: ${moneySpent}. Remaining: ${(startBalance - moneySpent):f2}");
                        break;
                    }
                }
            }
        }
    }
}
