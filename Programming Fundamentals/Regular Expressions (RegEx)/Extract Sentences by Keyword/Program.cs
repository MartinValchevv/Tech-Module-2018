using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Extract_Sentences_by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            string[] sentences = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string pattern = $@"\b{word}\b";

            foreach (var sentence in sentences)
            {
                if (Regex.IsMatch(sentence, pattern))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}
