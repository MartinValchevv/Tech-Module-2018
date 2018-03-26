using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] final = new int[lenght];
            int index = 0;
            int finalIndex = 0;
            int[] nums = new int[lenght];



            while (input != "Clone them!")
            {
                index++;
                nums = input.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int[] parametars = GetInfo(nums);
                if (IsBetter(parametars, final))
                {
                    final = nums;
                    finalIndex = index;
                }
                if (finalIndex == 0)
                {
                    final = nums;
                    finalIndex = index;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {finalIndex} with sum: {final.Sum()}.");
            Console.WriteLine(string.Join(" ", final));

        }

         static bool IsBetter(int[] parametars, int[] final)
        {
            int[] finalParametars = GetInfo(final);
            if (parametars[0] > finalParametars[0])
            {
                return true;
            }
            else if (parametars[0] == finalParametars[0])
            {
                if (parametars[1] < finalParametars[1])
                {
                    return true;
                } else if (parametars[1] == finalParametars[1])
                {
                    if(parametars[2] > finalParametars[2])
                    {
                        return true;

                    }
                }
            }
            return false;
        }

        static int[] GetInfo(int[] nums)
        {
            int sequence = 0;
            int position = 0;
            int sum = nums.Sum();
            int counter = 0;
            int counterMax = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    counter++;
                    if (counter > counterMax)
                    {
                        counterMax = counter;
                        position = i - counter + 1;
                    }
                }
                else
                {
                    counter = 0;
                }
            }
            sequence = counterMax;

            return new int[] { sequence, position, sum };
        }
    }
}
