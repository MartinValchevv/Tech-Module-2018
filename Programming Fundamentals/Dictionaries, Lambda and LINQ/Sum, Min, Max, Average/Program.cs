using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum__Min__Max__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] number = new int[n];

            for (int i = 0; i < n; i++)
            {
                number[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {number.Sum()}");
            Console.WriteLine($"Min = {number.Min()}");
            Console.WriteLine($"Max = {number.Max()}");
            Console.WriteLine($"Average = {number.Average()}");
        }
    }
}
