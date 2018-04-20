using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Band_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            int members = int.Parse(Console.ReadLine());
            double gitarPrice = double.Parse(Console.ReadLine());
            int vocalist = 1;
            int guitarists = members / 3;
            int drumers = members - vocalist - guitarists;
            double drumPrice = gitarPrice * 1.5;
            double microphonePrice = (drumers * drumPrice) - (guitarists * gitarPrice);
            double totalPriceDrumers = drumers * drumPrice;
            double totalPriceGitarist = guitarists * gitarPrice;
            double rentPerMonth = (totalPriceDrumers + totalPriceGitarist + microphonePrice) / members;
            double rentFor1Years = rentPerMonth * 12;
            double total = (totalPriceDrumers + totalPriceGitarist + microphonePrice) + rentFor1Years;
            Console.WriteLine($"Total cost: {total:F2}lv.");

        }
    }
}
