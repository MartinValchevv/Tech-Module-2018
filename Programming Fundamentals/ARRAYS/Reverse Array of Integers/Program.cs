using System;
using System.Linq;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] reversed = arr.Reverse().ToArray();
            string result = string.Join(" ", reversed);

            Console.WriteLine(result);
            
        }
    }
}
