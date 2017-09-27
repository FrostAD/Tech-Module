using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double doublePrice = 0;
            double suitePrice = 0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightsCount > 7)
                    {
                        studioPrice = studioPrice - (studioPrice * 0.05);
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightsCount > 14)
                    {
                        doublePrice = doublePrice - (doublePrice * 0.10);
                    }
                    break;
                case "July":
                case "August":
                case "December":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightsCount > 14)
                    {
                        suitePrice = suitePrice - (suitePrice * 0.15);
                    }
                    break;
                default:
                    break;
            }

            double endStudio = studioPrice * nightsCount;
            double endDouble = doublePrice * nightsCount;
            double endSuite = suitePrice * nightsCount;

            if (nightsCount > 7 && (month == "September" || month == "October")) 
            {
                switch (month)
                {
                    case "September": nightsCount -= 1;
                            endStudio = studioPrice * nightsCount; ; break;
                    case "October": ; endStudio= endStudio-(studioPrice); break;
                         

                }
            }

            

            Console.WriteLine($"Studio: {endStudio:f2} lv.");
            Console.WriteLine($"Double: {endDouble:f2} lv.");
            Console.WriteLine($"Suite: {endSuite:f2} lv.");


        }
    }
}
