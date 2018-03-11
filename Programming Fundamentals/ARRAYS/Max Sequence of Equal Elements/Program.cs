using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 1;
            int counterMax = 0;
            int numMax = 0;

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    counter++;
                }
                else
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numMax = arr[i];
                    }
                    counter = 1;
                }
                if ( i+1 == arr.Length -1)
                {
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        numMax = arr[i];
                    }
                    counter = 1;
                }
            }
            for (int i = 0; i < counterMax; i++)
            {
                Console.Write(numMax + " ");
            }
        }
    }
}
