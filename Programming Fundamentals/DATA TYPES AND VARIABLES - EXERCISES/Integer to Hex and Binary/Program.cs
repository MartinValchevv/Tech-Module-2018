using System;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(input, 16).ToUpper();
            Console.WriteLine(hex);
            string binary = Convert.ToString(input, 2);
            Console.WriteLine(binary);
        }
    }
}
