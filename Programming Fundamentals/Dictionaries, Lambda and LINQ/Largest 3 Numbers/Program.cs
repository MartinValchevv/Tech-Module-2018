using System;
using System.Collections.Generic;
using System.Linq;

namespace Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> number = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

           var result = number.OrderByDescending(x => x).Take(3);
            
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
