using System;
using System.Linq;

namespace _03RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{Convert.ToDecimal(array[i])} => {Math.Round((Convert.ToDecimal(array[i])), MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
