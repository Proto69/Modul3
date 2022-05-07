using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parents
    {
        private string name;
        private string rd;

        public Parents(string name, string rd)
        {
            Name = name;
            Rd = rd;
        }

        public override string ToString()
        {
            return $"{Name} {Rd}";
        }

        public string Rd { get => rd; set => rd = value; }
        public string Name { get => name; set => name = value; }
    }
}
