using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> seqance = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int position = 0;
            int sum = 0;
            int element = 0;
            int current = 0;

            while (seqance.Count > 0)
            {
                position = int.Parse(Console.ReadLine());
               if (position < 0)
                {
                    current = seqance[0];
                    seqance.RemoveAt(0);
                    seqance.Insert(0, seqance[seqance.Count - 1]);
                }
               else if (position >= seqance.Count)
                {
                    current = seqance[seqance.Count - 1];
                    seqance.RemoveAt(seqance.Count - 1);
                    seqance.Add(seqance[0]);
                }
               else
                {
                    current = seqance[position];
                    seqance.RemoveAt(position);

                }
                for (int i = 0; i < seqance.Count; i++)
                {
                    if (seqance[i] <= current)
                    {
                        seqance[i] += current;
                    }
                    else
                    {
                        seqance[i] -= current;
                    }
                }
                sum += current;
            }
            Console.WriteLine(sum);
        }
    }
}
