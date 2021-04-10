using System;

namespace _01Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfWagons = int.Parse(Console.ReadLine());
            int[] array = new int[countOfWagons];
            int sum = 0;
            for (int i = 0; i < countOfWagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                array[i] = people;
                sum += people;
            }
            Console.WriteLine(string.Join(' ', array));
            Console.WriteLine(sum);
        }
    }
}
