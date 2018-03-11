using System;
using System.Collections.Generic;
using System.Linq;

namespace Search_for_a_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] comand = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            if (numbers.Take(comand[0]).Skip(comand[1]).Contains(comand[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
