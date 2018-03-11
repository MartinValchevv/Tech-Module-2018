using System;

namespace Boolean_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool output = Convert.ToBoolean(input);

           if (output == true)
            {
                Console.WriteLine("Yes");
            }
           else
            {
                Console.WriteLine("No");
            }
        }
    }
}
