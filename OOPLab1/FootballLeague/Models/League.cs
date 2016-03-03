using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public static class League
    {
        private static List<Match> matches = new List<Match>();
        private static List<Team> teams = new List<Team>();

        public static IEnumerable<Team> Teams
        {
            get { return teams; }
        }

        public static IEnumerable<Match> Matches
        {
            get { return matches; }
        }

        public static void AddTeam(Team team)
        {
            if (ChechIfTeamExists(team))
            {
                throw new InvalidOperationException("Team already exists.");
            }
            teams.Add(team);
        }
        public static void AddMatch(Match match)
        {
            if (ChechIfMatchExists(match))
            {
                throw new InvalidOperationException("Match already exists.");
            }
            matches.Add(match);
        }
        private static bool ChechIfTeamExists(Team team)
        {
            return Teams.Any(t => t.Name == team.Name);
        }

        private static bool ChechIfMatchExists(Match match)
        {
            return Matches.Any(m => m.Id == match.Id);
        }
    }
}
