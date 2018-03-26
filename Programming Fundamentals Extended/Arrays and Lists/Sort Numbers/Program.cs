using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<double> numbers = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            numbers.Sort();

            Console.Write(string.Join(" <= ", numbers));
            
        }
    }
}
