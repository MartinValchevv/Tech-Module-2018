using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            string typePattern = @"^Type: (Normal|Warning|Danger)$";
            string sourcePattern = @"^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^!.,?]+)$";
            string current = "";
            List<string> result = new List<string>();
            string comand = Console.ReadLine();
            while (comand != "Davai Emo")
            {
                Match typeMatch = Regex.Match(comand, typePattern);
                Match sourceMatch = Regex.Match(comand, sourcePattern);
                Match forecastMarch = Regex.Match(comand, forecastPattern);

                Console.WriteLine($"({typeMatch.Groups[1]}) {forecastMarch.Groups[1]} ~ {sourceMatch.Groups[1]}");
               
                
                comand = Console.ReadLine();
            }
           

        }
    }
}
