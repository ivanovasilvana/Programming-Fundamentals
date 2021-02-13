using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string correctPassword = string.Empty;
            int counter = 0;

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
                correctPassword = password;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (correctPassword == input)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    counter++;
                    if (counter >= 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                    
                }
                
            }
        }
    }
}
