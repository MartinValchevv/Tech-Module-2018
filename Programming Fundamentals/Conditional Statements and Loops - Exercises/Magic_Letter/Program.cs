using System;

namespace Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char banned = char.Parse(Console.ReadLine());

            for (int i = first; i <= second; i++)
            {
                for (int j = first; j <= second; j++)
                {
                    for (int k = first; k <= second; k++)
                    {
                        if (i == banned || j == banned || k == banned) continue;
                        Console.Write($"{(char)i}{(char)j}{(char)k} ");
                    }
                }
            }
        }
    }
}
