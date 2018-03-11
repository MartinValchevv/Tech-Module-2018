using System;

namespace Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            one.ToString();
            two.ToString();
            three.ToString();

            Console.WriteLine($"{three}{two}{one}");
        }
    }
}
