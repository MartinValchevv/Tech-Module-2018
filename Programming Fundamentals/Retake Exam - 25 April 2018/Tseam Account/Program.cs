using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tseam_Account
{
    class Program
    {

            static void Main(string[] args)
            {
                List<string> games = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                List<string> installedGames = new List<string>();

                foreach (var item in games)
                {
                    installedGames.Add(item);
                }

                string command = Console.ReadLine();
                while (command != "Play!")
                {
                    string[] tokens = command.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string commandName = tokens[0];
                    string game = tokens[1];

                    if (commandName == "Install")
                    {
                        if (installedGames.Contains(game) == false)
                        {
                            games.Add(game);
                            installedGames.Add(game);
                        }
                    }
                    else if (commandName == "Uninstall")
                    {
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                        }
                    }
                    else if (commandName == "Update")
                    {
                        if (games.Contains(game))
                        {
                            games.Remove(game);
                            games.Add(game);
                        }

                    }
                    else if (commandName == "Expansion")
                    {
                        string[] tok = game.Split('-');
                        string gameName = tok[0];
                        string expansion = tok[1];

                        if (games.Contains(gameName))
                        {
                            int index = games.IndexOf(gameName);
                            string value = $"{gameName}:{expansion}";
                            if (index == games.Count - 1)
                            {
                                games.Add(value);
                            }
                            else
                            {
                                games.Insert(index + 1, value);
                            }
                        }
                    }
                    command = Console.ReadLine();
                }

                Console.WriteLine(string.Join(" ", games));
            }
        }
    }
