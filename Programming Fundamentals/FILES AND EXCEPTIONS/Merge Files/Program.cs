using System;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstFile = File.ReadAllLines("FileOne.txt");
            string[] secondFile = File.ReadAllLines("FileTwo.txt");

            for (int i = 0; i < firstFile.Length; i++)
            {
                File.AppendAllText("output.txt", firstFile[i] + Environment.NewLine + secondFile[i] + Environment.NewLine);
            }
        }
    }
}