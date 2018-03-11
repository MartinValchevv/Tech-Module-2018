using System;

namespace Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int number = 1;

            for (int col = 1; col <= num; col++)
            {
                for (int row = 1; row <= col; row++)
                {
                    
                    Console.Write($"{number} ");
                }
                number++;
                Console.WriteLine();
            }

        }
    }
}
