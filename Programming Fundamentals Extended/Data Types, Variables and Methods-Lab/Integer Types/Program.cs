using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            byte firs = byte.Parse(Console.ReadLine());
            uint second = uint.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            long four = long.Parse(Console.ReadLine());

            Console.WriteLine($"{firs} {second} {three} {four}");

        }
    }
}
