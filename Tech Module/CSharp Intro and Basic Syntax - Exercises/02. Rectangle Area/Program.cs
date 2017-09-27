using System;

namespace _02._Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideOne = double.Parse(Console.ReadLine());
            double sideTwo = double.Parse(Console.ReadLine());

            double sum = sideOne * sideTwo;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
