using System;
using System.Linq;

namespace _08MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                int currElement = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (currElement + array [j] == num)
                    {
                        Console.Write(currElement + " " + array[j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
