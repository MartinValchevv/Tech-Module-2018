using System;

namespace Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int qantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;

            if (type.Equals("Athlete"))
            {
                totalPrice = 0.70 * qantity;
            }
            else if (type.Equals("Businessman") || type.Equals("Businesswoman"))
            {
                totalPrice = 1.00 * qantity;
            }
            else if (type.Equals("SoftUni Student"))
            {
                totalPrice = 1.70 * qantity;
            }
            else
            {
                totalPrice = 1.20 * qantity;
            }

            Console.WriteLine($"The {type} has to pay {totalPrice:f2}.");
        }
    }
}
