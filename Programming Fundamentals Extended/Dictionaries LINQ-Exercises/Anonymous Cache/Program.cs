using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();
            while (input != "thetinggoesskrra")
            {
                string[] info = input.Split(new char[] { ' ', '-', '>', '|'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (info.Length == 1)
                {
                    string set = info[0];
                    if (!cache.ContainsKey(set))
                    {
                        Dictionary<string, long> current = new Dictionary<string, long>();
                        database.Add(set, current);
                    }
                    else
                    {
                        database.Add(set, cache[set]);
                        cache.Remove(set);
                    }
                }
                else
                {
                    string key = info[0];
                    long size = long.Parse(info[1]);
                    string set = info[2];
                    if (database.ContainsKey(set))
                    {
                        if (!database[set].ContainsKey(set))
                        {
                            database[set].Add(key, size);
                        }
                        else
                        {
                            database[set][key] += size;
                        }
                    }
                    else
                    {
                        if (!cache.ContainsKey(set))
                        {
                            Dictionary<string, long> current = new Dictionary<string, long>();
                            current.Add(key, size);
                            cache.Add(set, current);
                        }
                        else
                        {
                           if (!cache[set].ContainsKey(key))
                            {
                                cache[set].Add(key, size);
                            }
                           else
                            {
                                cache[set][key] += size;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var pair in database.OrderByDescending(x=>x.Value.Values.Sum()).Take(1))
            {
                Console.WriteLine($"Data Set: {pair.Key}, Total Size: {pair.Value.Values.Sum()}");
                foreach (var item in pair.Value)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }
        }
    }
}
