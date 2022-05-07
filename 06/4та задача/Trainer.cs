using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Trainer
    {
        private string name;
        private int countOfBadges = 0;
        private List<Pokemon> pokemons;

        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }

        public void DealDamage(List<Pokemon> pokemons, double damage)
        {
            for (int i = 0; i < pokemons.Count; i++)
            {
                pokemons[i].Health -= damage;
                if (pokemons[i].Health <= 0)
                {
                    pokemons.RemoveAt(i);
                    i--;
                }
            }
        }

        public override string ToString()
        {
            return $"{Name} {CountOfBadges} {Pokemons.Count}";
        }

        public int CountOfBadges { get => countOfBadges; set => countOfBadges = value; }
        public string Name { get => name; set => name = value; }
        internal List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
    }
}
