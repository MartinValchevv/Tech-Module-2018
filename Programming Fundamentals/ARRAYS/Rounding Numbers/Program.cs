using System;
using System.Linq;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] number = Console.ReadLine().Split(' ').Select(s =>double.Parse(s)).ToArray();

            for (double i = 0; i < number.Length; i++)
            {
                var value = Math.Round(i);
                Console.WriteLine($"{i} => {value}");
           
            }
        }
    }
}
