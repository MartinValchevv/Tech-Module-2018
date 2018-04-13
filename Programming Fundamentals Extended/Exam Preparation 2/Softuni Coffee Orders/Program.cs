using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());      
            decimal total = 0;
            for (int i = 0; i < countOfOrders; i++)
            {
                decimal pricePerCapsules = decimal.Parse(Console.ReadLine());
                string inputdate = Console.ReadLine();
                DateTime date = DateTime.ParseExact(inputdate, "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsules = long.Parse(Console.ReadLine());
                int daysInMounth = DateTime.DaysInMonth(date.Year, date.Month);
                decimal orderPrice = (daysInMounth * capsules) * pricePerCapsules;
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
                Console.WriteLine($"Total: ${total:F2}");
        }
    }
}
