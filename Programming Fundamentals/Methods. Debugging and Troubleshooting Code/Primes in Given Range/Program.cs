using System;
using System.Collections.Generic;


namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            List<int> primesInRange = FindPrimesInRange(startNum, endNum);
            Console.WriteLine(string.Join(", ", primesInRange.ToArray()));
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primesInRange = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primesInRange.Add(i);
                }
            }
            return primesInRange;
        }

        static bool IsPrime(long number)
        {
            long sqrt = (long)Math.Sqrt(number);
            bool isPrime = true;
            int i = 2;
            if (number >= 2)
            {
                while (isPrime && i <= sqrt)
                {
                    if (number % i == 0) isPrime = false;
                    i++;
                }
            }
            else isPrime = false;
            return isPrime;
        }
    }
}