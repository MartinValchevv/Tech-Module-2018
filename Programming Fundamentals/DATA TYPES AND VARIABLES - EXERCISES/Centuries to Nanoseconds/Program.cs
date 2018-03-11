using System;

namespace Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = byte.Parse(Console.ReadLine());
            short years = (short)(century * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            ulong mins = (ulong)hours * 60;
            long secs = (long)mins * 60;
            ulong milis = (ulong)secs * 1000;
            decimal micro = (decimal)milis * 1000;
            decimal nano = (decimal)micro * 1000;

            Console.WriteLine($"{century} centuries = {years} years = {days} days = {hours} hours = {mins} minutes = {secs} seconds = {milis} milliseconds = {micro} microseconds = {nano} nanoseconds");
        }
    }
}
