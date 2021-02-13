using System;

namespace _01.SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            double numThree = double.Parse(Console.ReadLine());

            double maxNum = 0;
            double minNum = 0;
            double averageNum = 0;

            if (numOne >= numTwo && numOne >= numThree)
            {
                maxNum = numOne;
                if (numTwo >= numThree)
                {
                    averageNum = numTwo;
                    minNum = numThree;
                }
                else
                {
                    averageNum = numThree;
                    minNum = numTwo;
                }
                
            }
            else if (numTwo > numOne && numTwo >= numThree)
            {
                maxNum = numTwo;
                if (numOne >= numThree)
                {
                    averageNum = numOne;
                    minNum = numThree;
                }
                else
                {
                    averageNum = numThree;
                    minNum = numOne;
                }
            }
            else if (numThree > numOne && numThree > numTwo)
            {
                maxNum = numThree;
                if (numOne >= numTwo)
                {
                    averageNum = numOne;
                    minNum = numTwo;
                }
                else
                {
                    averageNum = numTwo;
                    minNum = numOne;
                }
            }
            Console.WriteLine(maxNum);
            Console.WriteLine(averageNum);
            Console.WriteLine(minNum);
        }
    }
}
