using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> squence = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < squence.Count; i++)
            {
                if( i == 0)
                {
                    if (squence[i] == squence[i+1])
                    {
                        squence.RemoveAt(i + 1);
                        i = 0;
                    }
                }
                else if ( i == squence.Count - 1 )
                {
                    if (squence[i] == squence[i - 1])
                    {
                        squence.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else
                {
                    if (squence[i] == squence[i-1] + squence [i + 1])
                    {
                        squence.RemoveAt(i + 1);
                        squence.RemoveAt(i - 1);
                        i = 0;
                    }
                }     
            }
            Console.WriteLine(string.Join(" ", squence));
        }
    }
}
