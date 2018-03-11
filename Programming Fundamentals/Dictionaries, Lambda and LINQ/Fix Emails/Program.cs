using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> email = new Dictionary<string, string>();

            string name;

            while ((name = Console.ReadLine()) != "stop")
            {
                string inputEmail = Console.ReadLine();

                if (!(inputEmail.EndsWith(".us") || inputEmail.EndsWith(".uk")))
                {
                    if (!email.ContainsKey(name))
                    {
                        email.Add(name, "");
                    }
                    email[name] = inputEmail;
                }
            }
            foreach (var item in email)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

