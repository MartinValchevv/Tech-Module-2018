using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string phones = Console.ReadLine();
            string pattern = @"\+359(\s|-)[2]\1\d{3}\1\d{4}\b";

            MatchCollection phoneMatch = Regex.Matches(phones, pattern);

            string[] matchedPhones = phoneMatch.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.Write(string.Join(", ", matchedPhones));

        }
    }
}
