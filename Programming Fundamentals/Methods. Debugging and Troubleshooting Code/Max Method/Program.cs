using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int output = GetMax(a, b, c);
            Console.WriteLine(output);

      
        }

        private static int GetMax(int a, int b, int c)
        {
            int output = (Math.Max(Math.Max(a, b), c));
            return output;
        }
        }
    }

