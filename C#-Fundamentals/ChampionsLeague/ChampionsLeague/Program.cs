using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

class ChampionsLeague
{
    static void Main()
    {
        var mapNameTeam = new SortedDictionary<string, Team>();
        Regex regex = new Regex("(.+) \\| (.+) \\| ([0-9]+):([0-9]+) \\| ([0-9]+):([0-9]+)");
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "stop")
            {
                break;
            }
            Match match = regex.Match(input);
            string teamOneName = match.Groups[1].ToString();
            string teamTwoName = match.Groups[2].ToString();
            int teamOneGoals = int.Parse(match.Groups[3].ToString()) + int.Parse(match.Groups[6].ToString());
            int teamTwoGoals = int.Parse(match.Groups[4].ToString()) + int.Parse(match.Groups[5].ToString());
            Team teamOne = new Team(teamOneName);
            Team teamTwo = new Team(teamOneName);

            if (!mapNameTeam.ContainsKey(teamOneName))
            {
                mapNameTeam.Add(teamOneName, teamOne);
            }
            if (!mapNameTeam.ContainsKey(teamTwoName))
            {
                mapNameTeam.Add(teamTwoName, teamTwo);
            }            
            
            if (teamOneGoals > teamTwoGoals)
            {
                mapNameTeam[teamOneName].Wins++;
                mapNameTeam[teamOneName].Opponents.Add(teamTwoName);
                mapNameTeam[teamTwoName].Opponents.Add(teamOneName);
            }
            else if (teamOneGoals < teamTwoGoals)
            {
                mapNameTeam[teamTwoName].Wins++;
                mapNameTeam[teamTwoName].Opponents.Add(teamOneName);
                mapNameTeam[teamOneName].Opponents.Add(teamTwoName);
            }
            else
            {
                int teamTwoAwayScore = int.Parse(match.Groups[4].ToString());
                int teamOneAwayScore = int.Parse(match.Groups[6].ToString());
                if (teamOneAwayScore > teamTwoAwayScore)
                {
                    mapNameTeam[teamOneName].Wins++;
                    mapNameTeam[teamOneName].Opponents.Add(teamTwoName);
                    mapNameTeam[teamTwoName].Opponents.Add(teamOneName);
                }
                else if (teamOneAwayScore < teamTwoAwayScore)
                {
                    mapNameTeam[teamTwoName].Wins++;
                    mapNameTeam[teamTwoName].Opponents.Add(teamOneName);
                    mapNameTeam[teamOneName].Opponents.Add(teamTwoName);
                }
            }
        }

        var orderd = mapNameTeam.OrderByDescending(t => t.Value.Wins);

        foreach (var team in orderd)
        {
            Console.WriteLine(team.Key);
            Console.WriteLine($"- Wins: {team.Value.Wins}");
            Console.Write("- Opponents: ");
            Console.WriteLine(string.Join(", ",team.Value.Opponents.OrderBy(t =>t)));
        }
    }
}

class Team
{
    private string name;
    private int wins;
    private List<string> oponents;

    public Team(string name)
    {
        this.Name = name;
        oponents = new List<string>();
    }

    public List<string> Opponents
    {
        get { return this.oponents; }
    }

    public string Name
    {
        get
        {
            return this.name;
        }
        set
        {
            this.name = value;
        }
    }

    public int Wins
    {
        get
        {
            return this.wins;
        }
        set
        {
            this.wins = value;
        }
    }

    
}
