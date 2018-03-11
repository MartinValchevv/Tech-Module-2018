using System;
using System.Collections.Generic;
using System.Linq;

namespace Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] comand = Console.ReadLine().Split(' ').ToArray();

            while (comand[0] != "Odd" && comand[0] != "Even")
            {
                if (comand[0] == "Delete")
                {
                    numbers.RemoveAll(num => num == (int.Parse(comand[1])));
                }
                else if (comand[0] == "Insert")
                {
                    int element = int.Parse(comand[1]);
                    int index = int.Parse(comand[2]);
                    numbers.Insert(index, element);
                }
                comand = Console.ReadLine().Split(' ').ToArray();
                
            }
            if (comand[0] == "Odd")
            {
              numbers.RemoveAll(x => x % 2 == 0);
            }
            else if (comand[0] == "Even")
            {
               numbers.RemoveAll(x => x % 2 == 1);
            }
            Console.Write(string.Join(" ", numbers));
            Console.WriteLine();
        }
    }
}
