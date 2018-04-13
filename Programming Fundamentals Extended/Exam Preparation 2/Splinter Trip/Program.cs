using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            double distance = double.Parse(Console.ReadLine());
            double tank = double.Parse(Console.ReadLine());
            double milesWind = double.Parse(Console.ReadLine());

            double milesNormal = distance - milesWind;
            double fuelNedded = (milesNormal * 25 + milesWind * 25 * 1.5) * 1.05;
       
            Console.WriteLine($"Fuel needed: {fuelNedded:F2}L");
            if (fuelNedded <= tank)
            {
                Console.WriteLine($"Enough with {tank - fuelNedded:F2}L to spare!");
            }
            else
            {             
                Console.WriteLine($"We need {fuelNedded - tank:F2}L more fuel.");
            }

        }
    }
}
