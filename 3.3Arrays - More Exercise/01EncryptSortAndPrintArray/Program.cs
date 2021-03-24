using System;
using System.Linq;
using System.Collections;
namespace _01EncryptSortAndPrintArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string[] array = new string[length];
            int[] arrayInt = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] == 'a' || array[i][j] == 'e' || array[i] [j] == 'i' || array[i][j] == 'o'|| array[i] [j] =='u' ||array[i][j] == 'A' || array[i][j] == 'E' || array[i][j] == 'I' || array[i][j] == 'O' || array[i][j] == 'U')
                    {
                        sum += (array[i][j] * array[i].Length);
                    }
                    else
                    {
                        sum += (array[i][j] / array[i].Length);
                    }
                }
                arrayInt[i] = sum;
            }
            Array.Sort(arrayInt);
            Console.WriteLine(string.Join("\n", arrayInt));
        }
    }
}
