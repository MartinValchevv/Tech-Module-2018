using System;
using System.IO;

namespace Folder_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] directory = Directory.GetFiles("TestFolder");
            double size = 0;

            foreach (string file in directory)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }

            size = size / 1024 / 1024;

            Console.WriteLine(size);
        }
    }
}