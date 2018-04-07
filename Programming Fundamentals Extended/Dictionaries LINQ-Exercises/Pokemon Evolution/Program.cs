using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Evolution
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string name;
            string type;
            int index = 0;
            Dictionary<string, List<string>> pokemons = new Dictionary<string, List<string>>();
            while (input[0] == "wubbalubbadubdub")
            {
                if (input.Length > 1)
                {
                    name = input[0];
                    type = input[1];
                    index = int.Parse(input[2]);
                    string evolution = type + " <-> " + index;
                    if (!pokemons.ContainsKey(name))
                    {
                        List<string> current = new List<string>();
                        current.Add(evolution);
                        pokemons.Add(name, current);
                    }
                    else
                    {
                        pokemons[name].Add(evolution);
                    }
                }
                else
                {
                    name = input[0];
                    if (pokemons.ContainsKey(name))
                    {
                        Console.WriteLine($"# {name}");
                        foreach (var item in pokemons[name])
                        {
                            Console.WriteLine(item);
                        }
                    }
                }
                input = Console.ReadLine().Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
            foreach (var pair in pokemons)
            {
                Console.WriteLine($"# {pair.Key}");
                foreach (var ev in pair.Value.OrderByDescending(x=>int.Parse(x.Split(new[] { ' ', '-', '<', '>' },StringSplitOptions.RemoveEmptyEntries).Last())))
                {
                    Console.WriteLine(ev);
                }
            }
        }
    }
}
