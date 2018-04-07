using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> trains = new Dictionary<string, Dictionary<string, int>>();
            while (comand != "It's Training Men!")
            {
                string[] info = comand.Split(' ');
                if (info.Length == 5)
                {
                    string name = info[0];
                    string wagon = info[2];
                    int power = int.Parse(info[4]);
                    if (!trains.ContainsKey(name))
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        current.Add(wagon, power);
                        trains.Add(name, current);
                    }
                    else
                    {
                        if (!trains[name].ContainsKey(wagon))
                        {
                            trains[name].Add(wagon, power);
                        }
                    }
                }
                else if (info[1] == "->")
                {
                    string firs = info[0];
                    string other = info[2];
                    if (!trains.ContainsKey(firs))
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        trains.Add(firs, current);
                    }
                    foreach (var pair in trains[other])
                    {
                        trains[firs].Add(pair.Key, pair.Value);
                    }
                    trains.Remove(other);
                }
                else
                {
                    string firs = info[0];
                    string other = info[2];
                    if (!trains.ContainsKey(firs))
                    {
                        Dictionary<string, int> current = new Dictionary<string, int>();
                        trains.Add(firs, current);
                    }
                    trains[firs].Clear();
                    foreach (var pair in trains[other])
                    {
                        trains[firs].Add(pair.Key, pair.Value);
                    }
                }

                comand = Console.ReadLine();
            }
            foreach (var train in trains.OrderByDescending(x=>x.Value.Values.Sum()).ThenBy(x=>x.Value.Values.Count))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var item in train.Value.OrderByDescending(x=>x.Value))
                {
                    Console.WriteLine($"###{item.Key} - {item.Value}");
                }
            }
        }
    }
}
