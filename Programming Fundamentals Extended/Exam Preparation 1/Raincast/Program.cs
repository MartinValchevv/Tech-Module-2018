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
            string type = "";
            string source = "";
            string forecast = "";
            bool typeReady = false;
            bool sourceReady = false;
            bool forecastReady = false;
            List<string> result = new List<string>();
            string comand = Console.ReadLine();
            while (comand != "Davai Emo")
            {
               if (typeReady == false && Regex.IsMatch(comand, typePattern))
                {
                    Match t = Regex.Match(comand, typePattern);
                    type = t.Groups[1].Value;
                    typeReady = true;
                }
                if (sourceReady == false && typeReady == true && Regex.IsMatch(comand, sourcePattern))
                {
                    Match s = Regex.Match(comand, sourcePattern);
                    source = s.Groups[1].Value;
                    sourceReady = true;
                }
                if (forecastReady == false && sourceReady == true && typeReady == true && Regex.IsMatch(comand, forecastPattern))
                {
                    Match f = Regex.Match(comand, forecastPattern);
                    forecast = f.Groups[1].Value;
                    forecastReady = true;
                }
                if (forecastReady == true && sourceReady == true && typeReady == true)
                {
                    string final = $"({type}) {forecast} ~ {source}";
                    result.Add(final);
                    typeReady = false;
                    sourceReady = false;
                    forecastReady = false;
                }
                comand = Console.ReadLine();
            }

            foreach (var member in result)
            {
                Console.WriteLine(member);
            }

        }
    }
}
