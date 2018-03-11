using System;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            arr[0] = 1;

            for (int i = 1; i < n; i++)
            {
                int sum = 0;
                int counter = 0;
                for (int j = i; j >= 0; j--)
                {
                    sum += arr[j];
                    counter++;
                    if (counter > k)
                    {
                        break;

                    }
                }
                arr[i] = sum;
            }
            Console.WriteLine(string.Join(" ",arr));
        }
    }
}
