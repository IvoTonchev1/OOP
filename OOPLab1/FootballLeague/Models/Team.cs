using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Models
{
    public class Team
    {
        private string name;
        private string nickname;
        private DateTime dateOfFounding;
        private List<Player> players;
        private const int MinimumDateFounded = 1850;

        public Team(string name, string nickname, DateTime dateOfFounding)
        {          
            this.Name = name;
            this.Nickname = nickname;
            this.DateOfFounding = dateOfFounding;
            this.players = new List<Player>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Name must be at least 3 characters long.");
                }
                this.name = value;
            }
        }

        public string Nickname
        {
            get { return this.nickname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                {
                    throw new ArgumentException("Nickname must be at least 3 characters long.");
                }
                this.nickname = value;
            }
        }

        public DateTime DateOfFounding
        {
            get { return this.dateOfFounding; }
            set
            {
                if (value.Year < MinimumDateFounded)
                {
                    throw new ArgumentException("Year of founding cannot be earlier than " + MinimumDateFounded);
                }
                this.dateOfFounding = value;
            }
        }

        public IEnumerable<Player> Players
        {
            get { return this.players; }
        }

        public void AddPlayer(Player player)
        {
            if (CheckIfPlayerExists(player))
            {
                throw new InvalidOperationException("Player already exists for that team.");
            }
            this.players.Add(player);
        }

        private bool CheckIfPlayerExists(Player player)
        {
            return this.Players.Any(p => p.FirstName == player.FirstName && p.LastName == player.LastName);
        }

        public override string ToString()
        {
            return string.Format("{0}({1}, founded: {2})", this.Name, this.Nickname, this.DateOfFounding);
        }
    }
}
