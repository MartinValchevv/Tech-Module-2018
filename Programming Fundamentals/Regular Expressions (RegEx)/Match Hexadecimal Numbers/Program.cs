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

            Regex regex = new Regex(pattern);

            string number = Console.ReadLine();
            var numberMatches = Regex.Matches(number, pattern).Cast<Match>().Select(x => x.Value).ToArray();

            Console.WriteLine(string.Join(" ", numberMatches));


        }
    }
}
