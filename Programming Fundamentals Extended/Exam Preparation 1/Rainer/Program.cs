using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] fild = new int[input.Length - 1];
            int[] original = new int[input.Length - 1];
            int round = 0;
            for (int i = 0; i < fild.Length; i++)
            {
                fild[i] = input[i];
                original[i] = input[i];
            }
            int index = input[input.Length - 1];
            while (true)
            {
                for (int i = 0; i < fild.Length; i++)
                {
                    fild[i]--;
                }
                if (fild[index] == 0)
                {
                    break;
                }
                for (int i = 0; i <fild.Length; i++)
                {
                    if (fild[i] == 0)
                    {
                        fild[i] = original[i];
                    }
                }
                round++;
                index = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(string.Join(" ", fild));
            Console.WriteLine(round);
        }
    }
}
