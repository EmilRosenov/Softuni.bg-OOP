using System;
using System.Collections.Generic;

namespace _05.FootballTeamGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();
            string input = Console.ReadLine();


            while (input != "END")
            {
                string[] splitted = input.Split(';');
                string command = splitted[0];
                try
                {
                    if (command == "Team")
                    {
                        string clubName = splitted[1];
                        Team team = new Team(clubName);
                        teams.Add(clubName, team);
                    }
                    else if (command == "Add")
                    {
                        string clubName = splitted[1];

                        if (!teams.ContainsKey(clubName))
                        {
                            Console.WriteLine($"Team {clubName} does not exist.");
                            input = Console.ReadLine();
                            continue;
                        }

                        string playerName = splitted[2];
                        //95;82;82;89;68
                        int endurance = int.Parse(splitted[3]);
                        int sprint = int.Parse(splitted[4]);
                        int dribble = int.Parse(splitted[5]);
                        int passing = int.Parse(splitted[6]);
                        int shooting = int.Parse(splitted[7]);
                        Player player = new Player(playerName,
                                                    endurance,
                                                    sprint,
                                                    dribble,
                                                    passing,
                                                    shooting);
                        teams[clubName].Add(player);


                    }
                    else if (command == "Remove")
                    {
                        string clubName = splitted[1];
                        string playerName = splitted[2];
                        teams[clubName].RemovePlayer(playerName);

                    }
                    else if (command == "Rating")
                    {
                        string clubName = splitted[1];

                        if (!teams.ContainsKey(clubName))
                        {
                            Console.WriteLine($"Team {clubName} does not exist.");
                            input = Console.ReadLine();
                            continue;
                        }

                        Console.WriteLine($"{clubName} - {teams[clubName].Rating}");

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }


        }
    }
}

