using System;

namespace _04ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ');
            string[] newArray = new string[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[array.Length - i - 1] = array[i];
            }
            Console.WriteLine(string.Join(' ', newArray));
        }
    }
}
