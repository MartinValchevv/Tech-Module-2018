using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Anonymous_Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string placeholder = Console.ReadLine();
            string placeholderPattern = @"([A-Za-z]+)(.+)(\1)";
            string value = Console.ReadLine();
            string valuePattern = @"({)([A-Za-z]+)(})";
            MatchCollection placeholderMatch = Regex.Matches(placeholder, placeholderPattern);
            MatchCollection valueMatch = Regex.Matches(value, valuePattern);
            for (int i = 0; i < Math.Min(placeholderMatch.Count, valueMatch.Count); i++)
            {
                string change = placeholderMatch[i].Groups[2].Value;
                string put = valueMatch[i].Groups[2].Value;
                int index = placeholder.IndexOf(change);
                placeholder = placeholder.Remove(index, change.Length);
                placeholder = placeholder.Insert(index, put);
            }
            Console.WriteLine(placeholder);
        }
    }
}
