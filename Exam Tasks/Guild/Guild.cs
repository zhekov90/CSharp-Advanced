using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Guild
{
    public class Guild
    {
        private List<Player> roster;

        public Guild(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.roster = new List<Player>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }

        public void AddPlayer(Player player)
        {
            if (!this.roster.Any(p=>p.Name==player.Name) && this.roster.Count < this.Capacity)
            {
                this.roster.Add(player);
            }
        }

        public bool RemovePlayer(string name)
        {
            
            if (this.roster.Any(p=>p.Name==name))
            {
                Player player = this.roster.Where(p => p.Name == name).FirstOrDefault();
                this.roster.Remove(player);
                return true;
            }
            return false;
        }

        public void PromotePlayer(string name)
        {
            Player player = this.roster.Where(p => p.Name == name).FirstOrDefault();
            if (player.Rank != "Member")
            {
                player.Rank = "Member";
            }
        }

        public void DemotePlayer(string name)
        {
            if (roster.Any(x => x.Name == name))
            {
                Player myDemotedPlayer = roster.Where(x => x.Name == name).FirstOrDefault();
                myDemotedPlayer.Rank = "Trial";
            }
        }

        public Player[] KickPlayersByClass(string classs)
        {
            List<Player> playersToKick = new List<Player>();
            foreach (var player in this.roster)
            {
                if (player.Class==classs)
                {
                    playersToKick.Add(player);
                }
            }
            Player[] result = playersToKick.ToArray();
            this.roster = this.roster.Where(p => p.Class != classs).ToList();

            return result;

        }

        public int Count
        {
            get { return this.roster.Count; }

        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Players in the guild: {this.Name}");
            foreach (var player in this.roster)
            {
                sb.AppendLine(player.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
