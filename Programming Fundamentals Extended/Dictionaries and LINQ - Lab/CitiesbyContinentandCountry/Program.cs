using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesbyContinentandCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(' ');
                string continet = text[0];
                string country = text[1];
                string city = text[2];

                if (!dict.ContainsKey(continet))
                {
                    Dictionary<string, List<string>> current = new Dictionary<string, List<string>>();
                    current.Add(country, new List<string>() {city});
                    dict.Add(continet, current);
                }
                else
                {
                    if (!dict[continet].ContainsKey(country))
                    {
                        dict[continet].Add(country, new List<string>() { city });
                    }
                    else
                    {
                        dict[continet][country].Add(city);
                    }
                }
               
            }
            foreach (var pair in dict)
            {
                Console.WriteLine($"{pair.Key}:");
                foreach (var country in pair.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}
