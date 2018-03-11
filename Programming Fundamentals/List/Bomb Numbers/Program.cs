using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] comands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int bomb = comands[0];
            int range = comands[1];


            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bomb)
                {
                    for (int j = Math.Max(i - range, 0); j <= Math.Min(i + range, numbers.Count - 1); j++)
                    {
                        numbers[j] = 0;
                    }
                }
            }
            Console.WriteLine(numbers.Sum());
        }
    }
}