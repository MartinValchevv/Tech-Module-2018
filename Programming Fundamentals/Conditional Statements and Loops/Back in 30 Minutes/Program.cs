using System;

namespace Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());

            minute += 30;

            if (minute>59)
            {
                minute -= 60;
                hours++;
            }
            if (hours > 23)
            {
                hours -= 24;
            }

            Console.WriteLine($"{hours}:{minute:d2}");
            
        }
    }
}
