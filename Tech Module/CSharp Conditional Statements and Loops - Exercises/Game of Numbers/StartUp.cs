
namespace Game_of_Numbers
{
    using System;
    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            int lastI = 0;
            int lastJ = 0;
            int count = 0;
            bool isFound = false;

            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count++;
                    if (i+j == magic)
                    {
                        lastI = i;
                        lastJ = j;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Number found! {lastI} + {lastJ} = {magic}");
            }
            else
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
                
            }
        }
    }
}
