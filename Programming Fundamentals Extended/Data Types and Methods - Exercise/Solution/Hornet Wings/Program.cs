using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Wings
{
    class Program
    {
        static void Main(string[] args)
        {

            int wingsFlaps = int.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double tatalDistance = (wingsFlaps / 1000) * distance;

            long hornetFlapsForSeconds = wingsFlaps / 100;

            long rest = (wingsFlaps / endurance) * 5;

            long totalResult = rest + hornetFlapsForSeconds;

            Console.WriteLine($"{tatalDistance:F2} m.");
            Console.WriteLine($"{totalResult} s.");
        
        }
    }
}
