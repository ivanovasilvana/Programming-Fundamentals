using System;

namespace _02.EnglishNameOfTheLastDigit
{
    class Program
    {
        static string NameOfLastDigits()
        {
            int number = int.Parse(Console.ReadLine());
            int digit = number % 10;
            string name = string.Empty;
            if (digit == 0)
            {
                name = "zero";
            }
            else if (digit == 1)
            {
                name = "one";
            }
            else if (digit == 2)
            {
                name = "two";
            }
            else if (digit == 3)
            {
                name = "three";
            }
            else if (digit == 4)
            {
                name = "four";
            }
            else if (digit == 5)
            {
                name = "five";
            }
            else if (digit == 6)
            {
                name = "six";
            }
            else if (digit == 7)
            {
                name = "seven";
            }
            else if (digit == 8)
            {
                name = "eight";
            }
            else if (digit == 9)
            {
                name = "nine";
            }
            return (name);

        }

        static void Main(string[] args)
        {
            Console.WriteLine(NameOfLastDigits());
           
        }
    }
}
