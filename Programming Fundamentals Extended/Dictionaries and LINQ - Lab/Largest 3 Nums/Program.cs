using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_3_Nums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList().OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
