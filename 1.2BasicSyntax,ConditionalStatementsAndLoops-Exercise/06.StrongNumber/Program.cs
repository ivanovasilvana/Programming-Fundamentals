using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = num;
            int currentNumber = 0;
            int factorial = 1;
            int factorialSum = 0;

            while (number != 0)
            {
                currentNumber = number % 10;
                number /= 10;

                for (int i = 1; i <= currentNumber; i++)
                {
                    factorial *= i;
                }

                factorialSum += factorial;
                factorial = 1;
            }
            if (factorialSum == num)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
