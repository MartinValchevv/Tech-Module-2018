using System;
using System.Collections.Generic;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = number.Length / 4;

            var rowLeft = number.Take(k).Reverse().ToArray();
            var rowRight = number.Reverse().Take(k).ToArray();
            var row1 = rowLeft.Concat(rowRight).ToArray();
            var row2 = number.Skip(k).Take(2 * k).ToArray();

            var sumNumber = row1.Select((x, index) => x + row2[index]);
            Console.WriteLine(string.Join(" ", sumNumber));
        }
    }
}
