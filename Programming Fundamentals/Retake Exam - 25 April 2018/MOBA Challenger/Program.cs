using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> players = new Dictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

            while (input != "Season end")
            {
                if (input.Contains("->"))
                {
                    string[] playersInfo = input.Split(new[] {' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string playerName = playersInfo[0];
                    string playerPosition = playersInfo[1];
                    int playerSkill = int.Parse(playersInfo[2]);

                    if (!players.ContainsKey(playerName))
                    {
                        players.Add(playerName, new Dictionary<string, int>());
                        players[playerName].Add(playerPosition, playerSkill);
                    }
                    else
                    {
                        if (!players[playerName].ContainsKey(playerPosition))
                        {
                            players[playerName].Add(playerPosition, playerSkill);
                        }
                        else
                        {
                            if (players[playerName][playerPosition] < playerSkill)
                            {
                                players[playerName][playerPosition] = playerSkill;
                            }
                        }
                    }
                }
                else
                {
                    string[] duelPlayers = input.Split(new[] {' ', 'v', 's' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    string firstPlayer = duelPlayers[0];
                    string secondPlayer = duelPlayers[1];
                    if (players.ContainsKey(firstPlayer) && players.ContainsKey(secondPlayer))
                    {
                        string currPosition = "";
                        bool doesExist = false;
                        foreach (var positionFirst in players[firstPlayer].Keys)
                        {
                            foreach (var positionSecond in players[secondPlayer].Keys)
                            {
                                if (positionFirst.Equals(positionSecond))
                                {
                                    currPosition = positionSecond;
                                    doesExist = true;
                                    break;
                                }
                            }

                            if (doesExist == true)
                            {
                                if (players[firstPlayer][currPosition] > players[secondPlayer][currPosition])
                                {
                                    players.Remove(secondPlayer);
                                }
                                else if (players[firstPlayer][currPosition] < players[secondPlayer][currPosition])
                                {
                                    players.Remove(firstPlayer);
                                }
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            foreach (var winner in players.Keys.OrderByDescending(s => players[s].Values.Sum()).ThenBy(x => x))
            {
                Console.WriteLine($"{winner}: {players[winner].Values.Sum()} skill");
                foreach (var pos in players[winner].Keys.OrderByDescending(x => players[winner][x]).ThenBy(y => y))
                {
                    Console.WriteLine($"- {pos} <::> {players[winner][pos]}");
                }
            }
        }
    }
}