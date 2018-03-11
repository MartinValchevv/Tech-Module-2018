using System;

namespace Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int time = seconds + minute * 60 + hours * 3600;

            float metarForSec = (float)distance / time;
            float kmForHours = ((float)distance / 1000) / ((float)time / 3600);
            float miliForHour = ((float)distance / 1609) / ((float)time / 3600);

            Console.WriteLine($"{metarForSec:0.#####}");
            Console.WriteLine($"{kmForHours:0.#####}");
            Console.WriteLine($"{miliForHour:0.#####}");


        }
    }
}
