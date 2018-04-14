using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            long days = long.Parse(Console.ReadLine());
            long runners = long.Parse(Console.ReadLine());
            long laps = long.Parse(Console.ReadLine());
            long lapsLenght = long.Parse(Console.ReadLine());
            long trackCapacity = long.Parse(Console.ReadLine());
            double money = double.Parse(Console.ReadLine());
       
            long maxRunners = trackCapacity * days;
            long willRun = Math.Min(maxRunners, runners);
            long totalMeters = willRun * laps * lapsLenght;
            long totalKilometars = totalMeters / 1000;
            double moneyRaised = totalKilometars * money;

            Console.WriteLine($"Money raised: {moneyRaised:F2}");

        }
    }
}
