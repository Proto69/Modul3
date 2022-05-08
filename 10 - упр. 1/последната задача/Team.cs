using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Team
    {
        private string name;
        private List<Person> players = new List<Person>();
        private double rating;

        public Team(string name)
        {
            this.name = name;
        }

        public void AddPlayer(Person player)
        {
            players.Add(player);
        }

        public void RemovePlayer(string playerName)
        {
            for (int i = 0; i < players.Count; i++)
            {
                if (players[i].Name == playerName) 
                { 
                    players.RemoveAt(i); 
                    break; 
                }
            }
        }

        public override string ToString()
        {
            if (players.Count >= 1)
            {
                foreach (var item in players)
                {
                    rating += item.AvgRating;
                }
                rating /= players.Count;
            }
            return $"{Name} - {rating}";
        }

        public string Name { get => name; set => name = value; }
        public double Rating { get => rating; set => rating = value; }
        internal List<Person> Players { get => players; set => players = value; }
    }
}
