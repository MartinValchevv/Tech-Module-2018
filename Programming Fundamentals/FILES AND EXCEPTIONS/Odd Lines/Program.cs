using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {

            var lines = File.ReadAllLines("input.txt");

            var result  = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if ( i % 2 != 0)
                {
                    var curentOdd = lines[i];

                    result.AppendLine(curentOdd);
                }
            }
            File.WriteAllText("Output.txt", result.ToString());

        }
    }
}
