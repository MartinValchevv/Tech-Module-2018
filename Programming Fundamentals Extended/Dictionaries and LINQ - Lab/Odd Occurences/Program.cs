using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Occurences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine().ToLower().Split(' ').ToArray();
            var dict = new Dictionary<string, int>();
            foreach (var pair in sequence)
            {
                if (!dict.ContainsKey(pair))
                {
                    dict.Add(pair, 1);
                }
                else
                {
                    dict[pair]++;
                }
            }

            var result = new List<string>();
            foreach (var item in dict)
            {
                if (item.Value % 2 == 1)
                {
                    result.Add(item.Key);
                }
               
            }
            Console.WriteLine(string.Join(", ", result));

        }
    }
}
