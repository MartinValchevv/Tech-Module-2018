using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            int region = int.Parse(Console.ReadLine());
            decimal density = decimal.Parse(Console.ReadLine());
            decimal result = 0M;

            for (int i = 0; i < region; i++)
            {
                string[] regionInfo = Console.ReadLine().Split(' ');
                long raindropsCount = long.Parse(regionInfo[0]);
                int squareMeters = int.Parse(regionInfo[1]);
                result += (raindropsCount /(decimal) squareMeters);
                
            }
           if (density == 0)
            {
                Console.WriteLine($"{result:F3}");
            }
           else
            {
                result = result / density;
                Console.WriteLine($"{result:F3}");
            }
        }
    }
}
