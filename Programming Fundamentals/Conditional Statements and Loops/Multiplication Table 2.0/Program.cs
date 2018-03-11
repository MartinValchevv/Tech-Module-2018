using System;

namespace Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int theInteger = int.Parse(Console.ReadLine());
            int times = int.Parse(Console.ReadLine());
           

            while (times <= 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                times += 1;
                if (times > 10)
                {
                    return;
                }          
               
            }
            while (times > 10)
            {
                Console.WriteLine($"{theInteger} X {times} = {theInteger * times}");
                return;
            }
        }
    }
}
