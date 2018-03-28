using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?:0x)?[0-9A-F]+\b";
            string input = Console.ReadLine();

            var numbers = Regex.Matches(input, pattern).Cast<Match>().Select(a => a.Value).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
