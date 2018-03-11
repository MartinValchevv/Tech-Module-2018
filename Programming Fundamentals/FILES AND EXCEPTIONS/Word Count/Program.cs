using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Word_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            char[] delimiters = new char[] { ' ', ',', '.', '!', '?', '-', '_', '+', '\r', '\n' };
            string[] text = File.ReadAllText("text.txt").ToLower().Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordsCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                wordsCount[word] = 0;
            }

            foreach (string word in text)
            {
                if (wordsCount.ContainsKey(word))
                {
                    wordsCount[word]++;
                }
            }

            foreach (KeyValuePair<string, int> pair in wordsCount.OrderByDescending(p => p.Value))
            {
                File.AppendAllText("output.txt", string.Format("{0} - {1}{2}", pair.Key, pair.Value, Environment.NewLine));
            }
        }
    }
}
