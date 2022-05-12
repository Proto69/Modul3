using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Tyre
    {
        private string name;
        private double hardness;
        private double degradtion = 100;
        private double grip;

        public Tyre(string name, double hardness , double grip) : this(name, hardness)
        {
            this.Grip = grip;
        }

        public Tyre(string name, double hardness)
        {
            this.Name = name;
            this.Hardness = hardness;
        }

        public string Name { get => name; set => name = value; }
        public double Hardness { get => hardness; set => hardness = value; }
        public double Degradtion { get => degradtion; set => degradtion = value; }
        public double Grip { get => grip; set => grip = value; }
    }
}
