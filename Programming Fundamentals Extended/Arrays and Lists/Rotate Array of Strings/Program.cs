using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();

            string temp = input[input.Length - 1];

            var result = new string[input.Length];

            for (int i = 1; i < input.Length; i++)
            {
                result[i] = input[i - 1];
            }
            result[0] = temp;

            Console.Write(string.Join(" ", result));
        }
    }
}
