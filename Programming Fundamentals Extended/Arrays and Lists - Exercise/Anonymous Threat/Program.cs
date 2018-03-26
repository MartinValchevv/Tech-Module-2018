using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> text = Console.ReadLine().Split(' ').ToList();
            string[] comand = Console.ReadLine().Split(' ').ToArray();

            while (comand[0] != "3:1")
            {
                if (comand[0] == "merge")
                {
                    int starIndex = int.Parse(comand[1]);
                    int endIndex = int.Parse(comand[2]);
                    if (starIndex < 0)
                    {
                        starIndex = 0;
                    }
                    if (endIndex >= text.Count)
                    {
                        endIndex = text.Count - 1;
                    }
                    for (int i = starIndex; i < endIndex; i++)
                    {
                        text[starIndex] = text[starIndex] + text[starIndex + 1];
                        text.RemoveAt(starIndex + 1);
                    }
                }
                else if (comand[0] == "divide")
                {
                    int index = int.Parse(comand[1]);
                    int partitions = int.Parse(comand[2]);
                    int numberOfLatters = text[index].Length / partitions;
                    string current = text[index];
                    var divided = new List<string>();
                    for (int i = 0; i < partitions; i++)
                    {
                        divided.Add(current.Substring(0, numberOfLatters));
                        current = current.Remove(0, numberOfLatters);
                    }
                    divided[divided.Count - 1] = divided[divided.Count - 1] + current;
                    text.RemoveAt(index);
                    text.InsertRange(index, divided);

                }

                comand = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
