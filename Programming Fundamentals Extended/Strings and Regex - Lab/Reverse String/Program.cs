using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            char[] charArr = text.ToCharArray();
            Array.Reverse(charArr);

            Console.WriteLine(charArr);
        }
    }
}
