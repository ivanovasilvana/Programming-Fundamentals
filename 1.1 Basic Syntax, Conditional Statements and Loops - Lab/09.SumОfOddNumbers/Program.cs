using System;

namespace _09.SumОfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            {
                for (int i = 0; i <= num * 2; i++)
                {
                    if (i % 2 != 0)
                    {
                        sum += i;
                        Console.WriteLine(i);
                    }
                }
               
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
