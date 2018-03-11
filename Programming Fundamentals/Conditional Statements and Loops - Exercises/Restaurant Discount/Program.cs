using System;

namespace Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countPeople = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            double hallPrice = 0;
            double packagePrice = 0;
            double discount = 0;

            if (countPeople <= 50)
            {
                hallPrice = 2500;
                hallName = "Small Hall";
            }
            else if (countPeople > 50 && countPeople <= 100)
            {
                hallPrice = 5000;
                hallName = "Terrace";
            }
            else if (countPeople > 100 && countPeople <= 120)
            {
                hallPrice = 7500;
                hallName = "Great Hall";
            } else
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package.Equals("Normal"))
            {
                packagePrice = 500;
                discount = 5;
            }
            else if (package.Equals("Gold"))
            {
                packagePrice = 750;
                discount = 10;
            }
            else if (package.Equals("Platinum"))
            {
                packagePrice = 1000;
                discount = 15;
            }

            double totalPrice = hallPrice + packagePrice;
            double totalDiscount = totalPrice * discount / 100;
            totalPrice -= totalDiscount;
            double pricePerson = totalPrice / countPeople;

            Console.WriteLine($"We can offer you the {hallName}");
            Console.WriteLine($"The price per person is {pricePerson:f2}$");


        }
    }
}
