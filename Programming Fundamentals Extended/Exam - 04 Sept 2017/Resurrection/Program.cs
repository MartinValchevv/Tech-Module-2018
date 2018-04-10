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
            int phoenixes = int.Parse(Console.ReadLine());

            for (int i = 0; i < phoenixes; i++)
            {
                long lenght = long.Parse(Console.ReadLine());
                decimal width = decimal.Parse(Console.ReadLine());
                long lengthOf1Wing = long.Parse(Console.ReadLine());
                decimal totalYears = (lenght * lenght) * ( width + (2 * lengthOf1Wing));
                Console.WriteLine(totalYears);
            }  
        }
    }
}
