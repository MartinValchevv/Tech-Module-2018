using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger factorial = GetFactorial(number);
            Console.WriteLine(factorial);
        }

        static BigInteger GetFactorial(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
        
    }


