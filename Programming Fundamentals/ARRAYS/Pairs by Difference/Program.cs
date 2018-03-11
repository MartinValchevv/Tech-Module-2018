using System;
using System.Linq;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difrence = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length-1; j++)
                {
                    if (Math.Abs(arr[i] - arr[j+1]) == difrence)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
