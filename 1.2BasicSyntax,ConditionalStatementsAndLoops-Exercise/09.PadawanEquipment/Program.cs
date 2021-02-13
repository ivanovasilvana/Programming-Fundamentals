using System;

namespace _09.PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double countOfLightsaber = Math.Ceiling(countOfStudents + countOfStudents * 0.1);
            double price = priceOfLightsaber * countOfLightsaber + priceOfRobe * countOfStudents + priceOfBelt * countOfStudents;

            int counter = 0;

            for (int i = 1; i <= countOfStudents; i++)
            {
                counter++;
                if (counter == 6)
                {
                    price -= priceOfBelt;
                    counter = 0;
                }
            }

            if (price <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(price - money):f2}lv more.");
            }
        }
    }
}
