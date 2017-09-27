using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                while (true)
                {
                int num = int.Parse(Console.ReadLine());
                    count++;
                }

            }
            catch (Exception)
            {

                Console.WriteLine(count);
            }
        }
    }
}
