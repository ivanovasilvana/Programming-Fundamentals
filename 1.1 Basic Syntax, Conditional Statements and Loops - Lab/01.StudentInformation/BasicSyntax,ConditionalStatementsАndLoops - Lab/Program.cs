using System;

namespace BasicSyntax_ConditionalStatementsАndLoops___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {averageGrade:f2}");
        }
    }
}
