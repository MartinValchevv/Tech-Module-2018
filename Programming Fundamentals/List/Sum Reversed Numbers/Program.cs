using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int result = 0;
            

            for (int i = 0; i < numbers.Count; i++)
            {
                result += Reverse(numbers[i]);
            }

            Console.WriteLine(result);

          
        }

         static int Reverse(int result)
        {
            return int.Parse(result.ToString().Reverse().Aggregate("", (x, y) => x + y));
        }
    }
}
