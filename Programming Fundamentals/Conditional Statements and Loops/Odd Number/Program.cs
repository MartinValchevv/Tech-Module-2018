using System;

namespace Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());

            while (true)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                     num = double.Parse(Console.ReadLine());
                }
                else if (num < 0)
                {
                    double result = num * -1;
                    Console.WriteLine($"The number is: {result}");
                    return;
                } else
                {
                    Console.WriteLine($"The number is: {num}");
                    return;
                }
            }
        }
    }
}
