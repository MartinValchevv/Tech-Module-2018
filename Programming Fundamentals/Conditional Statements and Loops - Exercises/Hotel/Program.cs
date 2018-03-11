using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());
            double studio = 0;
            double doubleromm = 0;
            double suite = 0;
            double discount = 0;
            



            if (month.Equals("May") || month.Equals("October"))
            {
                studio = nightsCount * 50;
                doubleromm = nightsCount * 65;
                suite = nightsCount * 75;
                if (nightsCount > 7 && month.Equals("October"))
                {
                    studio = (nightsCount - 1) * 50;
                }
                if (nightsCount > 7)
                {
                    discount = studio * 5 / 100;
                    studio = studio - discount;
                }
                    
              
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                studio = nightsCount * 60;
                doubleromm = nightsCount * 72;
                suite = nightsCount * 82;
                if (nightsCount > 7 && month.Equals("September"))
                {
                    studio = (nightsCount - 1) * 60;
                    
                } else if (nightsCount > 14)
                {
                    discount = doubleromm * 10 / 100;
                    doubleromm = doubleromm - discount;
                   
                }
            }
            else if (month.Equals("July") || month.Equals("August") || month.Equals("December"))
            {
                studio = nightsCount * 68;
                doubleromm = nightsCount * 77;
                suite = nightsCount * 89;
                if (nightsCount > 14)
                {
                    discount = suite * 15 / 100;
                    suite = suite - discount;
                    
                }
            }

                Console.WriteLine($"Studio: {studio:f2} lv.");
                Console.WriteLine($"Double: {doubleromm:f2} lv.");
                Console.WriteLine($"Suite: {suite:f2} lv.");

            }
        }
    }
