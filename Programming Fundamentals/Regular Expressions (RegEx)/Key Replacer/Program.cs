using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z]+)([<\|\\])(.*)([<\|\\])([A-Za-z]+)";
            string input = Console.ReadLine();
            Match myMatch = Regex.Match(input, pattern);
            string start = myMatch.Groups[1].Value;
            string end = myMatch.Groups[5].Value;
            string input2 = Console.ReadLine();
            string pattern2 = $@"{start}(.*?){end}";
            StringBuilder stringBuilder = new StringBuilder();

            MatchCollection results = Regex.Matches(input2, pattern2);

            foreach (Match m in results)
            {
                stringBuilder.Append(m.Groups[1].Value);
            }
           
            if (stringBuilder.ToString().Length == 0)
            {
                Console.WriteLine("Empty result");
            }
            else
            {
                Console.WriteLine(stringBuilder);
            }
        }
    }
}
