﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Substring_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string word = Console.ReadLine().ToLower();
            int counter = 0;
            int index = text.IndexOf(word);

            while (index != -1)
            {
                counter++;
                index = text.IndexOf(word, index + 1);
            }

            Console.WriteLine(counter);
        }
    }
}
