using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> mates = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "Blaze it!")
            {
                string[] info = input.Split(new[] { '-', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string creature = info[0];
                string mate = info[1];
                if (!mates.ContainsKey(creature))
                {
                    List<string> friends = new List<string>();
                    friends.Add(mate);
                    mates.Add(creature, friends);
                }
                else
                {
                    if (!mates[creature].Contains(mate) && mate != creature)
                    {
                        mates[creature].Add(mate);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var pair in mates)
            {
                for (int i = 0; i < pair.Value.Count; i++)
                {
                    if (mates.ContainsKey(pair.Value[i]))
                    {
                        if (mates[pair.Value[i]].Contains(pair.Key))
                        {
                            mates[pair.Value[i]].Remove(pair.Key);
                            mates[pair.Key].Remove(pair.Value[i]);
                            i--;
                        }
                    }
                }
            }
            foreach (var pair in mates.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{pair.Key} : {pair.Value.Count}");
            }
        }
    }
}