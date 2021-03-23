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
               string [] items = Console.ReadLine().Split(' ').ToArray();
               string zeroElement = items[0];
                string firstElement = items[1];
            
                    if (i % 2 != 0)
                    {
                        secondArray[i] = items[0];
                        firstArray[i] = items[1];
                    }
                    else
                    {
                       secondArray[i] = items[1];
                        firstArray[i] = items[0];
                    }
            }
            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));

        }
    }
}
