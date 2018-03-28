using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] word = Console.ReadLine().Split(new char[] { ' ', ','  }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string text = Console.ReadLine();

            foreach (var words in word)
            {
                if (text.Contains(words))
                {
                   text = text.Replace(words, new string('*', words.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
