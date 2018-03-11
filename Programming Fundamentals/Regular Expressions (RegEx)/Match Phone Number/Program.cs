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

            string rg = @"\+359(\s|-)[2]\1\d{3}\1\d{4}\b";
            

            Regex pattern = new Regex(rg);

            string phones = Console.ReadLine();

            var phoneMatch = Regex.Matches(phones, rg);

            string[] matchedPhones = phoneMatch.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.Write(string.Join(", ", matchedPhones));
        }
    }
}
