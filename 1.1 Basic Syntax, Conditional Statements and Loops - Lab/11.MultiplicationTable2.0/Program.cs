using System;

namespace _11.MultiplicationTable2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int result = 0;
            if (start > 10)
            {
                result = theInteger * start;
                Console.WriteLine($"{theInteger} X {start} = {result} ");
            }
            for (int i = start; i <= 10; i++)
            {
                result = theInteger * i;
                Console.WriteLine($"{theInteger} X {i} = {result} ");
            }
        }
    }
}
