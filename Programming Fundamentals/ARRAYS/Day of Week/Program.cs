using System;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string[] nameDays =  { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (day < 1 || day > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(nameDays[day-1]);
            }

        }
    }
}
