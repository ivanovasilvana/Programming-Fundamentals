using System;
using System.Linq;

namespace _04ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(' ').ToArray();
            int rotation = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotation; i++)
            {
                string rotate = array[0];
                for (int j = 1; j < array.Length; j++)
                {
                    array[j - 1] = array[j];
                }
                array[array.Length - 1] = rotate;
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
