using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i <= 10; i++)
            {
                int oddNumber = Math.Abs(int.Parse(Console.ReadLine()));

                if (oddNumber % 2 == 1)
                {
                    Console.WriteLine($"The number is: {oddNumber}");
                    return;
                }
                else
                {
                    Console.WriteLine($"Please write an odd number.");
                }
            }
        }
    }
}
