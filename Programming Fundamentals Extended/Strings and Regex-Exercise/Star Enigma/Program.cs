using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int decrytKey = 0;
            string pattern = @"([^@:!\->]*)@([A-Za-z]+)([^@:!\->]*):([0-9]+)([^@:!\->]*)!([AD])!([^@:!\->]*)->([0-9]+)([^@:!\->]*)";
            string input = "";
            List<Match> attacked = new List<Match>();
            List<Match> destroyed = new List<Match>();
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                decrytKey = CalculateDecryptKey(input);
                input = DecryptInput(input, decrytKey);
                if (Regex.IsMatch(input, pattern))
                {
                    Match current = Regex.Match(input, pattern);
                    if (current.Groups[6].Value == "A")
                    {
                        attacked.Add(current);
                    }
                    else
                    {
                        destroyed.Add(current);
                    }
                }
            }
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            foreach (Match item in attacked.OrderBy(x => x.Groups[2].Value))
            {
                Console.WriteLine($"-> {item.Groups[2].Value}");
            }
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            foreach (Match item in destroyed.OrderBy(x => x.Groups[2].Value))
            {
                Console.WriteLine($"-> {item.Groups[2].Value}");
            }

        }

         static string DecryptInput(string input, int decrytKey)
        {
            string result = "";
            for (int i = 0; i < input.Length; i++)
            {
                result += (char)(input[i] - decrytKey);
            }
            return result;
        }

        static int CalculateDecryptKey(string input)
        {
            List<char> latters = new List<char> { 's', 't', 'a', 'r', 'S', 'T', 'A', 'R' };
            int result = input.Count(x => latters.Contains(x));
            return result;
        }  
    }
}
