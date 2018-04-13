using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"TO: ([A-Z]*); MESSAGE: (.*);";
            string key = Console.ReadLine();
            string input = Console.ReadLine();
            List<Match> messeges = new List<Match>();
            while (input != "END")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match m = Regex.Match(input, pattern);
                    messeges.Add(m);
                }
                input = Console.ReadLine();
            }
            StringBuilder sb = new StringBuilder();
            foreach (Match item in messeges.OrderBy(x => x.Groups[1].Value))
            {
                for (int i = 0; i < item.Value.Length; i++)
                {
                    sb.Append((char)(item.Value[i] + int.Parse(key[i % key.Length].ToString())));
                }
                Console.WriteLine(sb);
                sb.Clear();
            }
        }
    }
}
