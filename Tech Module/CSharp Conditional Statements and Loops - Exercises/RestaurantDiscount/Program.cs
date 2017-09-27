using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();

            int hallPrice = 0;
            int packagePrice = 0;
            double discount = 0;
            string hall = string.Empty;
            bool isPossible = true;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                isPossible = false;
            }

            if (groupSize <= 50)
            {
                hallPrice = 2500;
                hall = "Small Hall";
            }
            else if (groupSize > 50 && groupSize <= 100)
            {
                hallPrice = 5000;
                hall = "Terrace";
            }
            else if (groupSize > 100 && groupSize <= 120)
            {
                hallPrice = 7500;
                hall = "Great Hall";
            }

            if (package == "Normal")
            {
                packagePrice = 500;
                discount = 0.05;
            }
            else if (package == "Gold")
            {
                packagePrice = 750;
                discount = 0.10;
            }
            else if (package == "Platinum")
            {
                packagePrice = 1000;
                discount = 0.15;
            }

            double totalPrice = hallPrice + packagePrice;
            totalPrice = totalPrice - (totalPrice * discount);

            double pricePerPerson = totalPrice / groupSize;

            if (isPossible)
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }

        }
    }
}
