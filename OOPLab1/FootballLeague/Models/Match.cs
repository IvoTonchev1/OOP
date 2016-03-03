using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public class Match
    {
        private int id;
        private Team homeTeam;
        private Team awayTeam;
        private Score score;

        public Match(int id, Team homeTeam, Team awayTeam, Score score)
        {
            if (homeTeam.Name == awayTeam.Name)
            {
                throw new ArgumentException("Home team and away team should be different teams.");
            }
            this.Id = id;
            this.AwayTeam = awayTeam;
            this.HomeTeam = homeTeam;
            this.Score = score;
        }

        public int Id
        {
            get { return this.id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be negative.");
                }
                this.id = value;
            }
        }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public Score Score { get; set; }

        public Team GetWinner()
        {
            if (this.IsDraw())
            {
                return null;
            }
            return this.Score.AwayTeamGoals > this.Score.HomeTeamGoals ? this.AwayTeam : this.HomeTeam;
        }

        private bool IsDraw()
        {
            return this.Score.AwayTeamGoals == this.Score.HomeTeamGoals;
        }

        public override string ToString()
        {
            return string.Format("Match ID : {0} \n{1} - {2}  {3}", this.Id, this.HomeTeam, this.AwayTeam, this.Score);
        }
    }
}
