using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           string [] lines = File.ReadAllLines("Input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                File.AppendAllText("Output.txt", string.Format("{0}. {1}\r\n", i + 1, lines[i]));
            }

        }
    }
}
