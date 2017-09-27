namespace _12._Test_Numbers
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            int sum = 0;
            int last = 0;
            int count = 0;

            int multiplier = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    multiplier = 3;
                    sum = sum + multiplier * (i * j);
                    
                    count++;
                    if (sum >= max)
                    {
                        Console.WriteLine($"{count} combinations");
                        Console.WriteLine($"Sum: {sum} >= {max}");
                        return;
                    }
                    
                }
            }
            if (sum < max)
            {
                Console.WriteLine($"{count} combinations");
                Console.WriteLine($"Sum: {sum}");
            }
        }
    }
}
