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
        private double strength;
        private double sprint;
        private double dribul;
        private double passes;
        private double shooting;
        private double avgRating;

        public Person(string name, double strength, double sprint, double dribul, double passes, double shooting)
        {
            Name = name;
            Strength = strength;
            Sprint = sprint;
            Dribul = dribul;
            Passes = passes;
            Shooting = shooting;
            avgRating = Math.Round((strength + sprint + dribul + passes + shooting) / 5);
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value == "")
                    throw new ArgumentException("A name should not be empty.");
                name = value;
            }
        }

        public double Strength
        {
            get { return strength; }
            set
            {
                if (value >= 100 || value <= 0)
                    throw new ArgumentException("Endurance should be between 0 and 100.");
                strength = value;
            }
        }

        public double Sprint
        {
            get { return sprint; }
            set
            {
                if (value >= 100 || value <= 0)
                    throw new ArgumentException("Sprint should be between 0 and 100.");
                sprint = value;
            }
        }

        public double Dribul
        {
            get { return dribul; }
            set
            {
                if (value >= 100 || value <= 0)
                    throw new ArgumentException("Dribul should be between 0 and 100.");
                dribul = value;
            }
        }

        public double Passes
        {
            get { return passes; }
            set
            {
                if (value >= 100 || value <= 0)
                    throw new ArgumentException("Passes should be between 0 and 100.");
                passes = value;
            }
        }

        public double Shooting
        {
            get { return shooting; }
            set
            {
                if (value >= 100 || value <= 0)
                    throw new ArgumentException("Shooting should be between 0 and 100.");
                shooting = value;
            }
        }

        public double AvgRating { get => avgRating; private set => avgRating = value; }
    }
}
