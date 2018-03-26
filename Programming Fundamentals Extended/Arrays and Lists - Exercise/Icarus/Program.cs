using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Icarus
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int index = int.Parse(Console.ReadLine());
            string[] comand = Console.ReadLine().Split(' ').ToArray();
            int damage = 1;

            while (comand[0] != "Supernova" )
            {
                int steps = int.Parse(comand[1]);

                if (comand[0] == "left")
                {
                    for (int i = 0; i < steps; i++)
                    {
                        if (index == 0)
                        {
                            index = list.Length - 1;
                            damage++;
                        }
                        else
                        {
                            index--;
                        }

                        list[index] -= damage;

                    }
                }

                else if (comand[0] == "right")
                {
                    for (int i = 0; i < steps; i++)
                    {

                        if (index == list.Length - 1)
                        {
                            index = 0;
                            damage++;
                        }
                        else
                        {
                            index++;
                        }

                        list[index] -= damage;
                    }
                }
                comand = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
