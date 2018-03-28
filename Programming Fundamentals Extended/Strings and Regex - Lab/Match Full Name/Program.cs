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
            string name = Console.ReadLine();
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matchName = Regex.Matches(name, pattern);

            foreach (Match names in matchName)
            {
                Console.Write(names + " ");
            }
            Console.WriteLine();

        }
    }
}
