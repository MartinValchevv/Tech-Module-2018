using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Real_Number_Types
{
    class Program
    {
        static void Main(string[] args)
        {

            int countOfDigit = int.Parse(Console.ReadLine());

            if (countOfDigit < 16)
            {
                double.Parse(Console.ReadLine());
            }
            else if (countOfDigit < 29)
            {
                decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine(countOfDigit);

        }
    }
}
