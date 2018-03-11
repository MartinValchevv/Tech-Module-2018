using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook_Upgrade
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            string[] funcion = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            while (funcion[0] != "END")
            {
                DifrenFuncion(phonebook, funcion);
                funcion = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

        }

        private static void DifrenFuncion(Dictionary<string, string> phonebook, string[] funcion)
        {
            switch (funcion[0])
            {
                case "A":
                    phonebook[funcion[1]] = funcion[2];
                    break;
                case "S":
                    if (phonebook.ContainsKey(funcion[1]))
                    {
                        Console.WriteLine($"{funcion[1]} -> {phonebook[funcion[1]]}");
                        break;
                    }
                    Console.WriteLine($"Contact {funcion[1]} does not exist.");
                    break;
                case "ListAll":
                    foreach (var name in phonebook.OrderBy(x => x.Key))
                    {
                        Console.WriteLine($"{name.Key} -> {name.Value}");
                    }
                   
                    break;

            }
        }
    }
}
