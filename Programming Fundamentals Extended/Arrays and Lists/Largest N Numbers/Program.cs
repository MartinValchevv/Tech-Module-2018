using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_N_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int range = int.Parse(Console.ReadLine());
            List<int> result = new List<int>();
            numbers.Sort();
            numbers.Reverse();
            for (int i = 0; i < range; i++)
            {
                result.Add(numbers[i]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
