using System;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string massage = "";
            bool canFit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                massage += "* sbyte\r\n";
                canFit = true;

            }
            catch (Exception) {}

            try
            {
                byte num = byte.Parse(number);
                massage += "* byte\r\n";
                canFit = true;

            }
            catch (Exception) {}

            try
            {
                short num = short.Parse(number);
                massage += "* short\r\n";
                canFit = true;

            }
            catch (Exception) { }
            try
            {
                ushort num = ushort.Parse(number);
                massage += "* ushort\r\n";
                canFit = true;

            }
            catch (Exception) { }
            try
            {
                int num = int.Parse(number);
                massage += "* int\r\n";
                canFit = true;

            }
            catch (Exception) { }
            try
            {
                uint num = uint.Parse(number);
                massage += "* uint\r\n";
                canFit = true;

            }
            catch (Exception) { }
            try
            {
                long num = long.Parse(number);
                massage += "* long\r\n";
                canFit = true;

            }
            catch (Exception) { }

            if (canFit)
            {
                Console.WriteLine($"{number} can fit in:");
                Console.WriteLine(massage);
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }

        }
    }
}
