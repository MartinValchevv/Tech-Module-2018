using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> type = new Dictionary<string, int>();

            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }
                int qantity = int.Parse(Console.ReadLine());

                if (!type.ContainsKey(resource))
                {
                    type.Add(resource, 0);

                }
                type[resource] += qantity;
            }
            foreach (var item in type)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
