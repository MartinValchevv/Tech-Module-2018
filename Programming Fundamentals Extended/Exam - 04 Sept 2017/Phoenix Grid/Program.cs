using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Phoenix_Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^([^\s_]{3}\.)+([^\s_]{3})*$";
            string comand = Console.ReadLine();
            while(comand != "ReadMe")
            {
                if (Regex.IsMatch(comand, pattern) || comand.Length == 3)
                {
                    bool isPalindrome = true;

                    for (int i = 0; i < comand.Length / 2; i++)
                    {
                        if (comand[i] != comand[comand.Length - 1 - i])
                        {
                            Console.WriteLine("NO");
                            isPalindrome = false;
                            break;
                        }
                    }
                    if (isPalindrome)
                    {
                        Console.WriteLine("YES");
                    }
                    
                } 
                else
                {
                    Console.WriteLine("NO");
                }
              
                comand = Console.ReadLine();
            }

        }
    }
}
