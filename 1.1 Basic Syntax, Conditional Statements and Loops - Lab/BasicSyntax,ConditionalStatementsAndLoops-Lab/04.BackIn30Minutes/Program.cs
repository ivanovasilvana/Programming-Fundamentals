using System;

namespace _04.BackIn30Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int output = minutes + 30;
            if (output >= 60 )
            {
                hours++;
                if (hours == 24)
                {
                    hours = 0;
                }

                output -= 60;
            }
            if (output < 10)
            {
                Console.WriteLine($"{hours}:0{output}");
            }
            else
            {
                Console.WriteLine($"{hours}:{output}");
            }

        }
    }
}
