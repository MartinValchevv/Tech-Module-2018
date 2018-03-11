using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _1Anonymous_Downsite
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSite = int.Parse(Console.ReadLine());
            int securityKey = int.Parse(Console.ReadLine());
            decimal totalLoss = 0;

            List<string> site = new List<string>();


            for (int i = 0; i < numberOfSite; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string siteName = input[0];
                decimal siteVisits = long.Parse(input[1]);
                decimal siteCommercialPricePerVisit = decimal.Parse(input[2]);

                site.Add(siteName);
                totalLoss += siteVisits * siteCommercialPricePerVisit;
             
            }

            BigInteger securityToken = BigInteger.Pow(securityKey, numberOfSite);

            Console.WriteLine(string.Join("\n" , site));
            Console.WriteLine($"Total Loss: {totalLoss:F20}");
            Console.WriteLine($"Security Token: {securityToken}");

        }
    }
}
