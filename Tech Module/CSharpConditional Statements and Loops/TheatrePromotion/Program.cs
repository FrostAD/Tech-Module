using System;

namespace TheatrePromotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            int priceForKids = 0;
            int priceForAdults = 0;
            int priceForZombies = 0;
            switch (day)
            {
                case "Weekday":
                    priceForKids = 12;
                    priceForAdults = 18;
                    priceForZombies = 12;
                    break;
                case "Weekend":
                    priceForKids = 15;
                    priceForAdults = 20;
                    priceForZombies = 15;
                    break;
                case "Holiday":
                    priceForKids = 5;
                    priceForAdults = 12;
                    priceForZombies = 10;
                    break;
                default:
                    break;
            }

            if (0 <= age && age <= 18)
            {
                Console.WriteLine($"{priceForKids}$");
            }
            else if (18 < age && age <=64)
            {
                Console.WriteLine($"{priceForAdults}$");
            }
            else if (64< age && age <= 122)
            {
                Console.WriteLine($"{priceForZombies}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
