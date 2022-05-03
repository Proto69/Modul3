using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Motor
    {
        private int speed;
        private int power;

        public int Power { get => power; set => power = value; }
        public int Speed { get => speed; set => speed = value; }
    }
}
