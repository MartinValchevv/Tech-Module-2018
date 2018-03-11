using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})(-|.|\/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";

            string dates = Console.ReadLine();

            var regex = Regex.Matches(dates, pattern);

            foreach (Match date in regex)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var years = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {years}");
            }
        }
    }
}
