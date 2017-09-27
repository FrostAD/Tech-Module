using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int ingredientsCount = int.Parse(Console.ReadLine());
            int cal = 0;

            for (int i = 1; i <= ingredientsCount; i++)
            {
                string ingredient = Console.ReadLine().ToLower();

                switch (ingredient)
                {
                    case "cheese":cal += 500;break;
                    case "tomato sauce":cal += 150;break;
                    case "salami":cal += 600;break;
                    case "pepper":cal += 50;break;
                    default:
                        break;
                }
            }
            Console.WriteLine($"Total calories: {cal}");
        }
    }
}
