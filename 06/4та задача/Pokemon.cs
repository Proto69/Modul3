using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Pokemon
    {
        private string name;
        private string element;
        private double health;

        public Pokemon(string name, string element, double health)
        {
            Name = name;
            Element = element;
            Health = health;
        }

        public double Health { get => health; set => health = value; }
        public string Element { get => element; set => element = value; }
        public string Name { get => name; set => name = value; }
    }
}
