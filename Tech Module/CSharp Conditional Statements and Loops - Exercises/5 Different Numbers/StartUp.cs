
namespace _5_Different_Numbers
{
    using System;

    public class StartUp
    {

        public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            bool isNum = true;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    for (int k = start; k <= end; k++)
                    {
                        for (int l = start; l <= end; l++)
                        {
                            for (int m = start; m <= end; m++)
                            {
                                if (start <= i && i < j && j < k && k < l && l < m && m <= end)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                    isNum = false;
                                }
                                
                            }
                        }
                    }
                }
            }
            if (isNum)
            {
                Console.WriteLine("No");
            }
        }
    }
}
