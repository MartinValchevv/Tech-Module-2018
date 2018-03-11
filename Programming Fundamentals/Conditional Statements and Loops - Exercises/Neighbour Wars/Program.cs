using System;

namespace Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int Peshodamage = int.Parse(Console.ReadLine());
            int GoshoDamage = int.Parse(Console.ReadLine());
            int PeshoLife = 100;
            int GoshoLife = 100;
            int round = 0;

            while (PeshoLife > 0 && GoshoLife > 0)
            {

                round++;
                if (round % 2 == 1)
                {
                    GoshoLife -= Peshodamage;
                    if (GoshoLife > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {GoshoLife} health.");
                    }
                }
                else
                {
                    PeshoLife -= GoshoDamage;
                    if (PeshoLife > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {PeshoLife} health.");
                    }
                }
                if (round % 3 == 0 && PeshoLife > 0 && GoshoLife > 0)
                {
                    PeshoLife += 10;
                    GoshoLife += 10;
                }

            }

            if (round % 2 == 0)
            {
                Console.WriteLine($"Gosho won in {round}th round.");
            }
            else
            {
                Console.WriteLine($"Pesho won in {round}th round.");
            }
        }
    }
}
