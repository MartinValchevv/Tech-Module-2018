using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"^(<\[[\W_]*?\]\.)(\.\[[^\W_]*\]\.)*$";

            while (input != "Traincode!")
            {

                MatchCollection result = Regex.Matches(input, pattern);
                foreach (Match item in result)
                {
                    Console.WriteLine(item);
                }
                input = Console.ReadLine();
            }
        }
    }
}
