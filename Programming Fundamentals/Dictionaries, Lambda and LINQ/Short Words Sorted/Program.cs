using System;
using System.Collections.Generic;
using System.Linq;

namespace Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {        
            List<string> text = Console.ReadLine().ToLower().Split( new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?' }, 
                StringSplitOptions.RemoveEmptyEntries).ToList();
            var resultWords = text.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();
            

            Console.WriteLine(string.Join(", ",resultWords));
         
        }
    }
}
