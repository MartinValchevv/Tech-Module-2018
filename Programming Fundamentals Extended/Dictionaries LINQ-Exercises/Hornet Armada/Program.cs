using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Armada
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> hornets = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> activity = new Dictionary<string, long>();
            long n = long.Parse(Console.ReadLine());
            for (long i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new[] { '-', '=', ':', '>', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                long activit = long.Parse(input[0]);
                string legion = input[1];
                string soldierType = input[2];
                long soldierCount = long.Parse(input[3]);
                if (!activity.ContainsKey(legion) )
                {
                    activity.Add(legion, activit);
                }
                else
                {
                    if (activity[legion] < activit)
                    {
                        activity[legion] = activit;
                    }
                }

                if (!hornets.ContainsKey(legion))
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();
                    current.Add(soldierType, soldierCount);
                    hornets.Add(legion, current);
                }
                else
                {
                    if (!hornets[legion].ContainsKey(soldierType))
                    {
                        hornets[legion].Add(soldierType, soldierCount);
                    }
                    else
                    {
                        hornets[legion][soldierType] += soldierCount;
                    }
                }
            }
            string [] comand = Console.ReadLine().Split(new[] {'\\', ' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (comand.Length == 1)
            {
                foreach (var pair in activity.OrderByDescending(x=>x.Value))
                {
                    if (hornets[pair.Key].ContainsKey(comand[0]))
                    {
                        Console.WriteLine($"{pair.Value} : {pair.Key}");
                    }     
                }
            }
            else
            {
                long act = long.Parse(comand[0]);
                string type = comand[1];

                foreach (var pair in hornets.Where(x=>x.Value.ContainsKey(type)).OrderByDescending(x => x.Value[type]))
                {
                    if (activity[pair.Key] < act)
                    {
                        Console.WriteLine($"{pair.Key} -> {pair.Value[type]}");
                    }
                }
            }
        }
    }
}
