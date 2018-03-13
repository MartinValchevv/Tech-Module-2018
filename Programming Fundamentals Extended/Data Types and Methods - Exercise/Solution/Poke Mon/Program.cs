using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            sbyte exhaustion = sbyte.Parse(Console.ReadLine());
            int counter = 0;
            int currentPower = power;

          while (currentPower >= distance)
            {
               if (currentPower  == power / 2 && power % 2 == 0 && exhaustion != 0)
                {
                    currentPower /= exhaustion;
                }
               if (currentPower < distance)
                {
                    break;
                }

                currentPower -= distance;
                counter++;
               
            }
            Console.WriteLine(currentPower);
            Console.WriteLine(counter);
          

        }
    }
}
