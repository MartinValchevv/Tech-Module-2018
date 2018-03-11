using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine().ToCharArray();

            foreach (var ch in text)
            {
                Console.Write($"\\u{(int)ch:x4}");
            }
            Console.WriteLine();
        }
    }
}
