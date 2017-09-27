using System;

namespace SumofOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int number = 1;
            int sum = 0;

            for (int i = 1; i <= num; i++)
            {
                sum += number;
                Console.WriteLine(number);
                number += 2;
            }
            Console.WriteLine($"Sum: {sum}");
            
        }
    }
}
