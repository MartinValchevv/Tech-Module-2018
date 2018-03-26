using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> behives = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> hornet = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < behives.Count; i++)
            {
                if (behives[i] < hornet.Sum())
                {
                    behives.RemoveAt(i);
                    i--;
                }
                else
                {
                    behives[i] -= hornet.Sum();
                    if (hornet.Count == 0)
                    {

                        Console.WriteLine(string.Join(" ", behives));
                        return;
                    }
                    hornet.RemoveAt(0);
                }
            }
                if (behives.Sum() > 0)
                {
                    Console.WriteLine(string.Join(" ", behives));
                }
                else
                {
                    Console.WriteLine(string.Join(" ", hornet));
                }

        }
    }
}
