using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Hornet_Comm
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string msgPattern = @"^([0-9]+) <-> ([A-Za-z0-9]+)$";
            string broadPattern = @"^([^0-9]+) <-> ([A-Za-z0-9]+)$";
            List<Match> broadcasts = new List<Match>();
            List<Match> messeges = new List<Match>();
           

            while (input != "Hornet is Green")
            {
               if (Regex.IsMatch(input, msgPattern))
                {
                    messeges.Add(Regex.Match(input, msgPattern));
                }
               else if (Regex.IsMatch(input, broadPattern))
                {
                    broadcasts.Add(Regex.Match(input, broadPattern));
                }

                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcasts.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {

                foreach (Match item in broadcasts)
                {
                    string replancy = item.Groups[2].Value;
                    replancy = UpdateLetters(replancy);
                    Console.WriteLine($"{replancy} -> {item.Groups[1].Value}");
                }
            }
        
            Console.WriteLine("Messages:");
            if (messeges.Count == 0)
            {
                Console.WriteLine("None");
            }
            else
            {

                foreach (Match item in messeges)
                {
                    string code = item.Groups[1].Value;
                    code = Reverse(code);
                    Console.WriteLine($"{code} -> {item.Groups[2].Value}");
                }
            }

        }

        static string Reverse(string code)
        {
            string result = "";
            for (int i = code.Length - 1; i >= 0; i--)
            {
                result += code[i];
            }
            return result;
        }

        static string UpdateLetters(string replancy)
        {
            string result = "";
            for (int i = 0; i < replancy.Length; i++)
            {
                if (char.IsUpper(replancy[i]))
                {
                    result += char.IsLower(replancy[i]);
                }
                else if (char.IsLower(replancy[i]))
                {
                    result += char.ToUpper(replancy[i]);
                }
                else
                {
                    result += replancy[i];
                }

            }
            return result;
        }
    }
}
