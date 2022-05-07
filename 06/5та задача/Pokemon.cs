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
        private string type;

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public override string ToString()
        {
            return $"{Name} {Type}";
        }

        public string Type { get => type; set => type = value; }
        public string Name { get => name; set => name = value; }
    }
}
