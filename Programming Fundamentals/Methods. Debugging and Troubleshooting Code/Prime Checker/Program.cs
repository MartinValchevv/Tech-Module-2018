using System;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            Console.WriteLine(IsPrime(num));
        }
        static bool IsPrime(long num)
        {
            bool isPrime = true;

            if (num <= 1)
            {
                isPrime = false;
            }
            for (long i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
    }
}