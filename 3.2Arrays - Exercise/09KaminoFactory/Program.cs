using System;
using System.Linq;

namespace _09KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int bestCount = 0;
            int counter = 0;
            int bestSum = 0;
            int bestBeginIndex = 0;
            string bestSequence = string.Empty;
            int bestCounter = 0;

            while ((input = Console.ReadLine()) != "Clone them!")
            {
                string sequence = input.Replace("!", "");

                string[] dnaParts = sequence.Split('0', StringSplitOptions.RemoveEmptyEntries);
                string bestSubSeqence = string.Empty;
                int sum = 0;
                int count = 0;
                counter++;
                foreach (string dnaPart in dnaParts)
                {
                    if (dnaPart.Length > count)
                    {
                        count = dnaPart.Length;
                        bestSubSeqence = dnaPart;
                    }
                    sum += dnaPart.Length;
                }
                int beginIndex = sequence.IndexOf(bestSubSeqence);

                if (count > bestCount ||
                    (count == bestCount && beginIndex < bestBeginIndex) ||
                    (count == bestCount && beginIndex == bestBeginIndex && sum > bestSum) || counter == 1) 
                {
                    bestCount = count;
                    bestSequence = sequence;
                    bestBeginIndex = beginIndex;
                    bestSum = sum;
                    bestCounter = counter;
                }
            }
            char[] result = bestSequence.ToCharArray(); 
            Console.WriteLine($"Best DNA sample {bestCounter} with sum: {bestSum}.");
            Console.WriteLine($"{string.Join(' ', result)}");
        }
    }
}
