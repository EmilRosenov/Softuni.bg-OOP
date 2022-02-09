using System;
using System.Collections.Generic;
using System.Text;

namespace _05.FootballTeamGenerator
{
    public class Player
    {
        private const int MaxStats = 100;
        private const int MinStats = 0;
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private Dictionary<string, List<Player>> teamsAndPlayersList;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Name = name;
            Endurance = endurance;
            Sprint = sprint;
            Dribble = dribble;
            Passing = passing;
            Shooting = shooting;
            teamsAndPlayersList = new Dictionary<string, List<Player>>();
        }

        public string Name 
        { 
            get=>this.name;
            private set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                this.name = value;
            }
        }
        public int Endurance 
        { 
            get=>this.endurance;
            private set
            {
                if (value <=MinStats || value >MaxStats)
                {
                    throw new ArgumentException($"Endurance should be between {MinStats} and {MaxStats}.");
                }
               this.endurance=value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value <= MinStats || value > MaxStats)
                {
                    throw new ArgumentException($"Sprint should be between {MinStats} and {MaxStats}.");
                }
                this.sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value <= MinStats || value > MaxStats)
                {
                    throw new ArgumentException($"Dribble should be between {MinStats} and {MaxStats}.");
                }
                this.dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value <= MinStats || value > MaxStats)
                {
                    throw new ArgumentException($"Passing should be between {MinStats} and {MaxStats}.");
                }
                this.passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (value <= MinStats || value > MaxStats)
                {
                    throw new ArgumentException($"Shooting should be between {MinStats} and {MaxStats}.");
                }
                this.shooting = value;
            }
        }


        public double Stats =>(this.Endurance + this.Sprint + this.Dribble + this.Passing + this.Shooting) / 5.0;
       
    }
}
