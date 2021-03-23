using System;
using System.Linq;

namespace _06EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int evenSum = 0;
            int oddSum = 0;
            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];

                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }
            result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
