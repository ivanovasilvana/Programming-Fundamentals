using System;
using System.Linq;

namespace _03Zig_ZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] firstArray = new string[n];
            string[] secondArray = new string[n];

            for (int i = 0; i < n; i++)
            {
                string[] items = Console.ReadLine().Split(' ').ToArray();

                if (i % 2 != 0)
                {
                    firstArray[i] = items[1];
                    secondArray[i] = items[0];
                }
                else
                {
                    firstArray[i] = items[0];
                    secondArray[i] = items[1];
                }
            }

            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}
