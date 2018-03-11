using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfOddnumbers = 0;
            int currentNum = 1;

            for (int i = 0; i < n; i++)
            {
                sumOfOddnumbers += currentNum;
                Console.WriteLine(currentNum);
                currentNum += 2;
            }
            Console.WriteLine($"Sum: {sumOfOddnumbers}");
        }
    }
}
