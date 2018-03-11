using System;

namespace Choose_a_Drink
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type.Equals("Athlete"))
            {
                Console.WriteLine("Water");
            }
            else if (type.Equals("Businessman") || type.Equals("Businesswoman")) {
                Console.WriteLine("Coffee");
            }
            else if (type.Equals("SoftUni Student"))
            {
                Console.WriteLine("Beer");
            }
            else
            {
                Console.WriteLine("Tea");
            }
                }
            }
        }


     
