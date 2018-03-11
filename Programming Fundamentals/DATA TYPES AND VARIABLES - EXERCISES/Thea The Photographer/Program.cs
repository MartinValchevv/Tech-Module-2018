using System;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPic = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());
            int uploadTime = int.Parse(Console.ReadLine());


            double filterPic = Math.Ceiling(numOfPic * (procent / 100.0));
            double first = (double)numOfPic * filterTime;
            double secont = (double) filterPic * uploadTime;
            double totalTime = (double) first + secont;

            TimeSpan time = TimeSpan.FromSeconds(totalTime);

            string formatToClock = time.ToString(@"d\:hh\:mm\:ss");
            Console.WriteLine(formatToClock);

        }
    }
}
