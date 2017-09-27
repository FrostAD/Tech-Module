using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredient = string.Empty ;
            int count = 0;

            for (int i = 1; i <= 20; i++)
            {
                ingredient = Console.ReadLine();
                if (ingredient== "Bake!")
                {
                    break;
                }

                Console.WriteLine($"Adding ingredient {ingredient}.");
                count++;
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
