
namespace Neighbour_Wars
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());

            int count = 0;

            int peshoHealth = 100;
            int goshoHealth = 100;

            while (true)
            {
                count++;

                if (count % 2 == 0)
                {
                    peshoHealth -= goshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {count}th round.");
                        return;
                    }
                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {count}th round.");
                        return;
                    }
                    Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoHealth} health.");
                }
                else
                {
                    goshoHealth -= peshoDamage;
                    if (peshoHealth <= 0)
                    {
                        Console.WriteLine($"Gosho won in {count}th round.");
                        return;
                    }
                    else if (goshoHealth <= 0)
                    {
                        Console.WriteLine($"Pesho won in {count}th round.");
                        return;
                    }
                    Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoHealth} health.");
                }


                if (count % 3 == 0)
                {
                    peshoHealth += 10;
                    goshoHealth += 10;
                }


            }
        }
    }
}
