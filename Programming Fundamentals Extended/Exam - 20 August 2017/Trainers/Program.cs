using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> teams = new Dictionary<string, decimal> { { "Technical Trainers", 0M}, { "Practical Trainers", 0M}, { "Theoretical Trainers", 0M } };

            for (int i = 0; i < n; i++)
            {
                long milies = long.Parse(Console.ReadLine());
                decimal tons = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine();
                long distanceMeters = milies * 1600;
                decimal cargoKilograms = tons * 1000;
                decimal money = (cargoKilograms * 1.5M) - ( 0.7M * distanceMeters * 2.5M);
                
                switch (team)
                {
                    case "Technical":
                        teams["Technical Trainers"] += money;
                        break;
                    case "Practical":
                        teams["Practical Trainers"] += money;
                        break;
                    case "Theoretical":
                        teams["Theoretical Trainers"] += money;
                        break;

                }

            }
            var winner = teams.OrderByDescending(x => x.Value).FirstOrDefault();

            Console.WriteLine($"The {winner.Key} win with ${winner.Value:F3}.");
        }
    }
}
