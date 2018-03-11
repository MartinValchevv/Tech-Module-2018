using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] events = new string[6];
            events[0] = "Now I feel good.";
            events[1] = "I have succeeded with this product.";
            events[2] = "Makes miracles.I am happy of theresults!";
            events[3] = "I cannot believe but now I feel awesome.";
            events[4] = "Try it yourself, I am very satisfied.";
            events[5] = "I feel great!";
            string[] phrases = new string[6];
            phrases[0] = "Excellent product.";
            phrases[1] = "Such a great product.";
            phrases[2] = "I always use that product.";
            phrases[3] = "Best product of itscategory.";
            phrases[4] = "Exceptional product.";
            phrases[5] = "I can’t live without this product.";
            string[] authors = new string[8];
            authors[0] = "Diana";
            authors[1] = "Petya";
            authors[2] = "Stella";
            authors[3] = "Elena";
            authors[4] = "Katya";
            authors[5] = "Iva";
            authors[6] = "Annie";
            authors[7] = "Eva";
            string[] cities = new string[5];
            cities[0] = "Burgas";
            cities[1] = "Sofia";
            cities[2] = "Plovdiv";
            cities[3] = "Varna";
            cities[4] = "Ruse";
            Random phraseIndex = new Random();
            Random eventIndex = new Random();
            Random authorIndex = new Random();
            Random townIndex = new Random();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{2}-{3}", phrases[phraseIndex.Next(0, 6)], events[eventIndex.Next(0, 6)], authors[authorIndex.Next(0, 8)], cities[townIndex.Next(0, 5)]);
            }



        }


    }
}
