using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Person
    {
        private string name;
        private Company company;
        private List<Pokemon> pokemons = new List<Pokemon>();
        private List<Parents> parents = new List<Parents>();
        private List<Children> children = new List<Children>();
        private Car car;

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} \nCompany: \n{Company} \nCar: \n{Car} \nPokemon: \n{string.Join("\n", Pokemons)}" +
                $"\nParents: \n{string.Join("\n", Parents)}" +
                $"\nChildren: \n{string.Join("\n", Children)}";
        }

        internal Car Car { get => car; set => car = value; }
        internal List<Children> Children { get => children; set => children = value; }
        internal List<Parents> Parents { get => parents; set => parents = value; }
        internal List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
        internal Company Company { get => company; set => company = value; }
        public string Name { get => name; set => name = value; }
    }
}
