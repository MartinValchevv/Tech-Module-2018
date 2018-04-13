using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> spies = new Dictionary<string, Dictionary<string, int>>();
            while (comand != "quit")
            {
                string[] info = comand.Split(new[] { " -> " }, StringSplitOptions.None).ToArray();
                string country = info[0];
                string name = info[1];
                int days = int.Parse(info[2]);
                if (!spies.ContainsKey(country))
                {
                    Dictionary<string, int> current = new Dictionary<string, int>();
                    current.Add(name, days);
                    spies.Add(country, current);
                }
                else
                {
                    if (!spies[country].ContainsKey(name))
                    {
                        spies[country].Add(name, days);
                    }
                    else
                    {
                        spies[country][name] = days;
                    }
                }
                comand = Console.ReadLine();
            }
            foreach (var pair in spies.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"Country: {pair.Key}");
                foreach (var item in pair.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"**{item.Key} : {item.Value}");
                }
            }
        }
    }
}
