using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (b - a > 3)
            {

                for (int i = a; i <= b; i++)
                {
                    for (int j = a; j <= b; j++)
                    {
                        for (int k = a; k <= b; k++)
                        {
                            for (int m = a; m <= b; m++)
                            {
                                for (int n = a; n <= b; n++)
                                {
                                    if (i < j && j < k && k < m && m < n)
                                    {
                                        Console.WriteLine($"{i} {j} {k} {m} {n}");
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
        