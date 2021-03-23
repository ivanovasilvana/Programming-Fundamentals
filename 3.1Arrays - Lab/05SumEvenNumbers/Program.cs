using System;
using System.Linq;

namespace _05SumEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split("\\s+").Select(int.Parse).ToArray();
            int evenSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNumber = array[i];
                if (currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
            }
            Console.WriteLine(evenSum);
        }
    }
}
