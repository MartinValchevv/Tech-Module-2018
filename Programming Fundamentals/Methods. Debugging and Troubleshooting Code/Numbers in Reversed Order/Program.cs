using System;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Reversed(input);
        }
        public static void Reversed(string input)
        {
            if (input.Length > 1)
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();
            }
        }
    }
}