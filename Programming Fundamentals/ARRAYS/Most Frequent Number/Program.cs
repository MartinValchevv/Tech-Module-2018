using System;
using System.Linq;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] counter = new int[arr.Length];
            int counterMax = 0;
            int numberMax = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter[i]++;
                        if (counter[i] > counterMax)
                        {
                            counterMax = counter[i];
                            numberMax = arr[i];
                        }
                    }
                }
            }
            Console.WriteLine(numberMax);
        }
    }
}
