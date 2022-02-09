using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Team
    {
        private int count;
        private string name;
        private int rating;
       
        private List<Player> players;

        public Team(string name)
        {
            Name = name;
           
            players = new List<Player>();
            
        }

        public string Name 
        {
            get=>this.name;
            private set 
            {
                if (string.IsNullOrEmpty(value)|| string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
           
        }
       
        public void Add(Player player)
        {
            if (!players.Contains(player))
            {
                players.Add(player);
               
            }
          
        }
        public void RemovePlayer(string playerName)
        {
            Player player = this.players.FirstOrDefault
                (x => x.Name == playerName);

            if (player==null)
            {
                throw new InvalidOperationException($"Player {playerName} is not in {this.Name} team.");
            }
            this.players.Remove(player);
        }

        public int Rating 
        {
            get=>this.players.Count==0?
                0 : (int)Math.Round(players.Average(x=>x.Stats)); 
        }

       
    }
}
