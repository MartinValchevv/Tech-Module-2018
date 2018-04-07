using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> customers = new Dictionary<string, List<int>>();
            string comand = Console.ReadLine();

            while (comand != "I believe I can fly!")
            {
                string[] info = comand.Split(' ').ToArray();
                if (info[1] != "=")
                {
                    string customer = info[0];
                    List<int> flight = new List<int>();
                    for (int i = 1; i <= info.Length-1; i++)
                    {
                        flight.Add(int.Parse(info[i]));
                    }
                    if (!customers.ContainsKey(customer))
                    {
                        customers.Add(customer, flight);
                    }
                    else
                    {
                        customers[customer].AddRange(flight);
                    }
                }
                else
                {
                    string custemer1 = info[0];
                    string custemer2 = info[2];
                    customers[custemer1] = customers[custemer2].ToList();
                }

                comand = Console.ReadLine();
            }
            foreach (var pair in customers.OrderByDescending(x=>x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ",pair.Value.OrderBy(x=>x))}");
            }
        }
    }
}
