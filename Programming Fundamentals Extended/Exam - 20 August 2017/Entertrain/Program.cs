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
            int sum = 0;
            List<int> train = new List<int>();
            string input = Console.ReadLine();

            while (input != "All ofboard!")
            {
                int wagon = int.Parse(input);
                sum += wagon;
                train.Add(wagon);
                if (sum > power)
                {
                    int average = sum / train.Count;
                    int first = train.OrderBy(x => Math.Abs(x - average)).First();
                    train.Remove(first);
                }
                input = Console.ReadLine();
            }
            train.Reverse();
            List<int> sorted = new List<int>(train) { power };
            Console.WriteLine(String.Join(" ", sorted));
        }
    }
}
