using System;

namespace Calories_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int cout = int.Parse(Console.ReadLine());
            int total = 0;
            int countCheese = 0;
            int countTomato = 0;
            int countSalami = 0;
            int countPepper = 0;

            for (int i = 1; i <= cout; i++)
            {
                string product = Console.ReadLine().ToLower();
                if (product == "cheese")
                {
                    countCheese++;
                }
                if (product == "tomato sauce")
                {
                    countTomato++;
                }
                if (product == "salami")
                {
                    countSalami++;
                }
                if (product == "pepper")
                {
                    countPepper++;
                }
            }
            total = countCheese * 500 + countTomato * 150 + countSalami * 600 + countPepper * 50;
            Console.WriteLine($"Total calories: {total}");

        }
    }
}
