using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[A-Za-z0-9]+(\.|-|_)?[A-Za-z0-9]+@[A-Za-z]+-?[A-Za-z]*(\.[A-Za-z]+)+\b";

            MatchCollection match =  Regex.Matches(input, pattern);

            foreach (Match m in match)
            {
                Console.WriteLine(m.Value);
            }

        }
    }
}
