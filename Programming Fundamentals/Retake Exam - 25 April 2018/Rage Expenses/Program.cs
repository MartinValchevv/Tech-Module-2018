using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGameCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headset = lostGameCount / 2;
            int mouse = lostGameCount / 3;
            int keyboard = lostGameCount / 6;
            int display = lostGameCount / 12;

            double headsetTotal = headset * headsetPrice;
            double mouseTotal = mouse * mousePrice;
            double keyboardTotal = keyboard * keyboardPrice;
            double displayTotal = display * displayPrice;

            double total = headsetTotal + mouseTotal + keyboardTotal + displayTotal;

            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
