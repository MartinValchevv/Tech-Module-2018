using System;
using System.Linq;

namespace Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool found = false;

            for (int i = 0; i < number.Length; i++)
            {
                for (int j = 0; j < number.Length; j++)
                {
                    for (int k = 0; k < number.Length; k++)
                    {
                        int a = number[i];
                        int b = number[j];
                        int c = number[k];

                        if (0 <= i && i < j)
                        {
                            if (a + b == c && i < j)
                            {

                                Console.WriteLine($"{a} + {b} == {a + b}");
                                found = true;
                                break;
                            }
                        }


                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("No");
            }
        }
    }
}