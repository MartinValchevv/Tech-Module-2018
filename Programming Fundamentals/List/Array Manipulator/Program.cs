using System;
using System.Collections.Generic;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<string> comand = Console.ReadLine().Split(' ').ToList();

            while (comand[0] != "print")
            {
                if (comand[0] == "add")
                {
                    int element = int.Parse(comand[2]);
                    int indexx = int.Parse(comand[1]);
                    numbers.Insert(indexx, element);
                }
                else if (comand[0] == "addMany")
                {
                    int index = int.Parse(comand[1]);
                    numbers.InsertRange(index, comand.Skip(2).Select(int.Parse));

                }
                else if (comand[0] == "cotains")
                {
                    int element = int.Parse(comand[1]);
                    if (numbers.Contains(element))
                    {
                        Console.WriteLine(numbers.IndexOf(element));
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }

                }
                else if (comand [0] == "remove")
                {
                    int index = int.Parse(comand[1]);
                    numbers.RemoveAt(index);
                }
                else if (comand[0] == "shift")
                {
                    int position = int.Parse(comand[1]) % numbers.Count;
                    var helper = numbers.Skip(position).ToList();
                    for (int i = 0; i < position; i++)
                    {
                        helper.Add(numbers[i]);
                    }
                    numbers = helper;

                }
                else if (comand[0] == "sumPairs")
                {
                    int cicles = numbers.Count /2;
                    for (int i = 0; i < cicles; i++)
                    {
                        numbers[i] += numbers[i + 1];
                        numbers.RemoveAt(i + 1);

                    }
                }
                comand = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine("[" + string.Join(", ", numbers) + "]");
        }
    }
}
