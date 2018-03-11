using System;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            if (n == 0 || n == 1)
            {
                Console.WriteLine("1");
                return;
            }
            else
            {
                int a = 1;
                int b = 1;
                int c = 0;
                for (int i = 1; i < n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                    sum = b;
                }
                
            }
            Console.WriteLine(sum);

        }
    }
}
