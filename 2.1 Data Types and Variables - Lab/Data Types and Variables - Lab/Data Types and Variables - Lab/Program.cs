using System;

namespace Data_Types_and_Variables___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            float pound = float.Parse(Console.ReadLine());
            float US = 1.31f * pound;
            Console.WriteLine($"{US:f3}");
        }
    }
}
