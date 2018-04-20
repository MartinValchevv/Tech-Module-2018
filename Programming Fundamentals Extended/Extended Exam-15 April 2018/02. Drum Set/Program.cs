using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Drum_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            double savings = double.Parse(Console.ReadLine());
            List<int> quality = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> drumBeat = new List<int>(quality);
            string input;

            while ((input = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int hitPower = int.Parse(input);

                for (int i = 0; i < drumBeat.Count; i++)
                {

                    drumBeat[i] -= hitPower;
                    if (drumBeat[i] <= 0)
                    {
                        double price = quality[i] * 3;
                        if (savings - price > 0)
                        {
                            drumBeat[i] = quality[i];
                            savings -= price;
                        }
                        else
                        {
                            drumBeat.RemoveAt(i);
                            quality.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", drumBeat));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
