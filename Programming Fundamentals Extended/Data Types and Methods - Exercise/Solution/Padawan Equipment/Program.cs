using System;

namespace Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            int student = int.Parse(Console.ReadLine());
            double lightsabers = double.Parse(Console.ReadLine());
            double robes = double.Parse(Console.ReadLine());
            double belt = double.Parse(Console.ReadLine());

            int freeBelt = student / 6;
            double sabersRound = Math.Ceiling(student + 0.1);

            double result = lightsabers * (sabersRound + student) + robes * (student) + belt * (student - freeBelt);
            double diff = result - cash;

            if (cash > result)
            {
                Console.WriteLine($"The money is enough - it would cost {result:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {diff:F2}lv more.");
            }

        }
    }
}
