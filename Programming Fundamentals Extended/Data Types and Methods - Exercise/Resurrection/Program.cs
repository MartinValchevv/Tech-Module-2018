using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int body = int.Parse(Console.ReadLine());
            decimal totalYears = 0;

            for (int i = 0; i < body; i++)
            {
                int lenght = int.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                decimal lenghtOf1Wing = decimal.Parse(Console.ReadLine());

                var powResult = BigInteger.Pow(lenght, 2);

                totalYears = (decimal) powResult * (width + 2 * lenghtOf1Wing);
                Console.WriteLine(totalYears);
            }

        }
    }
}
 