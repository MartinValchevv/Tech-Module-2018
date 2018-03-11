using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Full_Name
{
    class Program
    {
        static void Main(string[] args)
        {

            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            string names = Console.ReadLine();

            MatchCollection match = Regex.Matches(names, regex);

            foreach (Match name in match)
            {
                Console.Write(name.Value + " "); ;
            }
        }
    }
}
