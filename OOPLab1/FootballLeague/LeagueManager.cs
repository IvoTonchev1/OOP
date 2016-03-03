using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeague.Models;

namespace FootballLeague
{
    public static class LeagueManager
    {
        public static void HandleInput(string input)
        {
            var inputArgs = input.Split();
            switch (inputArgs[0])
            {
                case "AddTeam":
                    AddTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]));
                    break;
                case "AddMatch":
                    AddMatch(int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3], int.Parse(inputArgs[4]), int.Parse(inputArgs[5]));
                    break;
                case "AddPlayerToTeam":
                    AddPlayerToTeam(inputArgs[1], inputArgs[2], DateTime.Parse(inputArgs[3]), decimal.Parse(inputArgs[4]), inputArgs[5]);
                    break;
                case "ListTeams":
                    ListTeams();
                    break;
                case "ListMatches":
                    ListMatches();
                    break;
            }
        }

        private static void AddTeam(string name, string nickname, DateTime dateFounded)
        {
            var currentTeam = new Team(name, nickname, dateFounded);
            League.AddTeam(currentTeam);
            Console.WriteLine("Team added.");
        }

        private static void AddMatch(int id, string homeTeamName, string awayTeamName, int homeTeamGoals, int awayTeamGoals)
        {
            if (League.Matches.Any(m => m.Id == id))
            {
                throw new InvalidOperationException("Match already exists.");
            }
            var homeTeam = League.Teams.First(team => team.Name == homeTeamName);
            var awayTeam = League.Teams.First(team => team.Name == awayTeamName);
            var currentScore = new Score(homeTeamGoals, awayTeamGoals);
            var currentMatch = new Match(id, homeTeam, awayTeam, currentScore);
            League.AddMatch(currentMatch);
            Console.WriteLine("Match added.");
        }

        private static void AddPlayerToTeam(string fName, string lName, DateTime bDate, decimal salary, string team)
        {          
            var currentTeam = League.Teams.First(t => t.Name == team);
            var currentPlayer = new Player(fName, lName, bDate, salary);           
            currentTeam.AddPlayer(currentPlayer);
            currentPlayer.Team = currentTeam;
            Console.WriteLine("Player added to team.");
        }

        private static void ListTeams()
        {
            foreach (var team in League.Teams)
            {
                Console.WriteLine(team);
            }
        }

        private static void ListMatches()
        {
            foreach (var match in League.Matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
