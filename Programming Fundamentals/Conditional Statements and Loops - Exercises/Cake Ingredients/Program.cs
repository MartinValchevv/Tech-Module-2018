using System;

namespace Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int counter = 0;

            while (product != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {product}.");
                counter++;
                product = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
