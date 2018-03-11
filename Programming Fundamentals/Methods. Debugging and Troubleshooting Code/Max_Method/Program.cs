using System;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());

            string name = EnglishName(num);
            Console.WriteLine(name);
        }

        private static string EnglishName(long num)
        {
            num = Math.Abs(num);
            long lastDigit = num % 10;
            string name = "";

            switch (lastDigit)
            {
                case 0:
                    name = "zero";
                    break;
                case 1:
                    name = "one";
                    break;
                case 2:
                    name = "two";
                    break;
                case 3:
                    name = "three";
                    break;
                case 4:
                    name = "four";
                    break;
                case 5:
                    name = "five";
                    break;
                case 6:
                    name = "six";
                    break;
                case 7:
                    name = "seven";
                    break;
                case 8:
                    name = "eight";
                    break;
                case 9:
                    name = "nine";
                    break;
            }
            return name;
        }
    }
}
