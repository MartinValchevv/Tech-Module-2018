using System;

namespace Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counter = 0;
           


            while (true)
            {
                try
                {
                   int integer = int.Parse(Console.ReadLine());
                    counter++;
                    
                }
                catch (Exception)
                {
                    Console.WriteLine(counter);
                    return;

                }
                
            }
            
        }
    }
}                

