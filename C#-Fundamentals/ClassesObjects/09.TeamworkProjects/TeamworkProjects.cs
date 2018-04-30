using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TeamworkProjects
{
    class TeamworkProjects
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = CreateTeams(n);
            AddToTeams(teams);
            PrintTeams(teams);
        }

        public static List<Team> CreateTeams(int n)
        {
            var teams = new List<Team>();
            for (int i = 0; i < n; i++)
            {
                var args = Console.ReadLine().Split('-');
                string creatorName = args[0];
                string teamName = args[1];
                bool wasCreated = false;
                bool cantCreateAnotherTeam = false;
                foreach (var teamCheck in teams)
                {
                    if (teamCheck.TeamName == teamName)
                    {
                        Console.WriteLine($"Team {teamName} was already created!");
                        wasCreated = true;
                        break;
                    }
                    if (teamCheck.CreatorName == creatorName)
                    {
                        Console.WriteLine($"{creatorName} cannot create another team!");
                        cantCreateAnotherTeam = true;
                        break;
                    }
                }
                if (wasCreated || cantCreateAnotherTeam)
                {
                    continue;
                }
                Team team = new Team();
                team.CreatorName = creatorName;
                team.TeamName = teamName;
                teams.Add(team);
                Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
            }
            return teams;
        }
        public static void AddToTeams(List<Team> teams)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                var args = input.Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string name = args[0];
                string teamName = args[1];
                //bool cantJoinToTeam = false;
                bool teamDontExist = true; 
                foreach (var team in teams)
                {
                    if (team.TeamName == teamName)
                    {
                        teamDontExist = false;
                        if (team.CreatorName == name)
                        {
                            Console.WriteLine($"Member {name} cannot join team {teamName}!");
                            //cantJoinToTeam = true;
                            break;
                        }
                        else
                        {
                            team.Members.Add(name);
                        }
                    }    
                    
                }
                if (teamDontExist)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                //if (cantJoinToTeam )
                //{
                //    continue;
                //}
            }
        }
        public static void PrintTeams(List<Team> teams)
        {
            var sortedTeams = teams.OrderByDescending(t => t.Members.Count).ThenBy(t => t.TeamName).Where(t => t.Members.Count > 0);
            foreach (var team in sortedTeams)
            {
                Console.WriteLine(team.TeamName);
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            
            var teamToDisband = teams.Where(t => t.Members.Count == 0).Select(t => t.TeamName).ToArray();
            if (teamToDisband.Length >= 1)
            {
                Console.WriteLine("Teams to disband:");
                foreach (var team in teamToDisband)
                {
                    Console.WriteLine(team);
                }
            }
            
        }
    }
}
