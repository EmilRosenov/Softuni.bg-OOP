using System;
using System.Collections.Generic;
using System.Text;

namespace PlayersAndMonsters
{
    public class Hero
    {
        public int level; 
        public string username; 
        public Hero(string username,int level)
        {
            this.Level = level;
            this.Username = username;
        }

        public int Level { get; set; }
        public string Username { get; set; }


        public override string ToString()
        {
            return $"Type: {this.GetType().Name} Username: {this.Username} Level: {this.Level}";
        }
    }
}
