using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (isPalindrom(i) && SumDigits7(i) && HasEvenDigits(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

         static bool HasEvenDigits(int i)
        {
            int current = 0;
            bool hasEven = false;
           while (i != 0)
            {
                current = i % 10;
                if (current % 2 == 0)
                {
                    hasEven = true;
                    return hasEven;
                }
                i /= 10;
            }
            return hasEven;
        }

         static bool SumDigits7(int i)
        {
            int sumDigit = 0;
           while (i !=0)
            {
                sumDigit += i % 10;
                i /= 10;
            }
           if (sumDigit % 7 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

         static bool isPalindrom(int i)
        {
            int reverst = 0;
            int oldNumber = i;
            while (i != 0)
            {
                reverst *= 10;
                reverst += i % 10;
                i /= 10;
            }
            if (reverst == oldNumber)
            {
                return true;
            } else
            {
                return false;
            }
           
        }
    }
}
