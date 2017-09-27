using System;

namespace _04._Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energyContent = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());

            double energy = (volume * energyContent) / 100.00;
            double sugar = (sugarContent * volume) / 100.00;

            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {sugar}g sugars");
        }
    }
}
