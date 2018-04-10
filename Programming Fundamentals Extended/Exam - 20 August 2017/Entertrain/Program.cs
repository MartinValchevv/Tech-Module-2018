using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            List<int> train = new List<int>();
            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int wagon = int.Parse(input);
                train.Add(wagon);

                if (train.Sum() > power)
                {
                    int average = (int)(train.Average());
                    int indexRemove = 0;
                    int smallestDifference = int.MaxValue;

                    for (int i = 0; i < train.Count; i++)
                    {
                        if (Math.Abs(train[i] - average) < smallestDifference)
                        {
                            smallestDifference = Math.Abs(train[i] - average);
                            indexRemove = i;
                        }
                    }
                    train.RemoveAt(indexRemove);
                }
                input = Console.ReadLine();
            }
            train.Insert(0, power);
            train.Reverse();
            Console.WriteLine(String.Join(" ", train));
        }
    }
}
