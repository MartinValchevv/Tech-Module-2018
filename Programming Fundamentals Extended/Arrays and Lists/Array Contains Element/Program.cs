using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Contains_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int containNumber = int.Parse(Console.ReadLine());
            bool isFound = false;
           

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == containNumber)
                {
                    isFound = true;
                    break;
                }
           
            }
            if (isFound)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
