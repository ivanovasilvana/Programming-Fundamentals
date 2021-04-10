using System;
using System.Linq;

namespace _07MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestCount = 0;
            int bestIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int currentElement = array[i];
                int counter = 0;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currentElement == array[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCount)
                {
                    bestCount = counter;
                    bestIndex = i;
                }
            }
            for (int i = 0; i <= bestCount; i++)
            {
                Console.Write(array[bestIndex] + " ");
            }
        }
    }
}
