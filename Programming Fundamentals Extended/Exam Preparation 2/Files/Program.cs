using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> database = new Dictionary<string, Dictionary<string, long>>();
            for (long i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine().Split(';').ToArray();
                string directory = info[0];
                long size = long.Parse(info[1]);
                List<string> fileInfo = directory.Split('\\').ToList();
                string file = fileInfo[fileInfo.Count - 1];
                fileInfo.RemoveAt(fileInfo.Count - 1);
                string root = string.Join("\\", fileInfo);
                if (!database.ContainsKey(root))
                {
                    Dictionary<string, long> current = new Dictionary<string, long>();
                    current.Add(file, size);
                    database.Add(root, current);
                }
                else
                {
                    if (!database[root].ContainsKey(file))
                    {
                        database[root].Add(file, size);
                    }
                    else
                    {
                        database[root][file] = size;
                    }
                }
            }
            string[] final = Console.ReadLine().Split(new[] { " in " }, StringSplitOptions.None).ToArray();
            string exteishen = final[0];
            string place = final[1];
            Dictionary<string, long> wanted = new Dictionary<string, long>();
            foreach (var pair in database)
            {
                if (pair.Key.StartsWith(place + "\\"))
                {
                    foreach (var item in pair.Value)
                    {
                        if (item.Key.EndsWith("." + exteishen))
                        {
                            wanted.Add(item.Key, item.Value);                        
                        }
                    }
                }
            }
            if (wanted.Count > 0)
            {
                foreach (var w in wanted.OrderByDescending(x => x.Value).OrderBy(x => x.Key))
                {
                    Console.WriteLine($"{w.Key} - {w.Value} KB");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
