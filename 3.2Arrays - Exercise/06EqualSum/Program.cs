using System;
using System.Linq;

namespace _06EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isFound = false;

            for (int curr = 0; curr < array.Length; curr++)
            {
                int rightSum = 0;
                for (int i = curr + 1; i < array.Length; i++)
                {
                    rightSum += array[i];
                }

                int leftSum = 0;
                for (int i = curr - 1; i >= 0; i--)
                {
                    leftSum += array[i];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(curr);
                    isFound = true;
                    break;
                }

            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }

        }
    }
}
