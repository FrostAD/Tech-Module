
namespace Magic_Letter
{
    using System;
    public class Program
    {
        public static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char stop = char.Parse(Console.ReadLine());

            for (char i = start; i <= end; i++)
            {
                for (char j = start; j <= end; j++)
                {
                    for (char k = start; k <= end; k++)
                    {
                        if (i != stop && j != stop && k != stop)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }

        }
    }
}
