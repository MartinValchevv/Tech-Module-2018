using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            BigInteger result = num1 + num2;
            Console.WriteLine(result);
        }
    }
}
