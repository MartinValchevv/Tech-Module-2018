using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Wormtest
{
    class Program
    {
        static void Main(string[] args)
        {
            long lenghtMeters = long.Parse(Console.ReadLine())*100;
            double widhtCentimetars = double.Parse(Console.ReadLine());

            double reminder = lenghtMeters / widhtCentimetars;

            if (lenghtMeters % reminder == 0 || widhtCentimetars == 0)
            {
                Console.WriteLine($"{lenghtMeters * widhtCentimetars:F2}");
            }
            else
            {
                Console.WriteLine($"{reminder * 100:F2}%");
            }
        }
    }
}
