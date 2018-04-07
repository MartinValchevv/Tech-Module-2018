using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            Dictionary<string, List<string>> forces = new Dictionary<string, List<string>>();
            while (comand != "Lumpawaroo")
            {
                if (comand.Contains("|"))
                {
                    string[] info = comand.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = info[1].Trim();
                    string side = info[0].Trim();
                    if (!forces.Values.Any(x=>x.Contains(name)))
                    {
                        if (!forces.ContainsKey(side))
                        {
                            forces.Add(side, new List<string>() { name });
                        }
                        else
                        {
                            forces[side].Add(name);
                        }
                    }
                }
                else
                {
                    string[] info = comand.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string name = info[0].Trim();
                    string side = info[1].Trim();
                    if (!forces.ContainsKey(side))
                    {
                        forces.Add(side, new List<string>());
                    }

                    if (forces.Values.Any(x=>x.Contains(name)))
                    {
                        foreach (var pair in forces)
                        {
                            if (pair.Value.Contains(name))
                            {
                                forces[pair.Key].Remove(name);
                            }
                        }
                    }
                    forces[side].Add(name);
                    Console.WriteLine($"{name} joins the {side} side!");
                }
                comand = Console.ReadLine();
            }
            foreach (var pair in forces.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                if (pair.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
                    foreach (var member in pair.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"! {member}");
                    }
                }
            }
        }
    }
}
