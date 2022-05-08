using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(';').ToArray();
            Team team = new Team(input[1]);
            while ((input = Console.ReadLine().Split(';').ToArray())[0] != "END")
            {
                switch (input[0])
                {
                    case "Add":
                        if (CheckForTheTeam(team, input[1]))
                        {
                            try
                            {
                                team.AddPlayer(new Person(input[2], double.Parse(input[3]),
                                    double.Parse(input[4]), double.Parse(input[5]),
                                    double.Parse(input[6]), double.Parse(input[7])));
                            }
                            catch (ArgumentException k) { Console.WriteLine(k.Message); }
                        }
                        else Console.WriteLine($"Team {input[1]} does not exists.");
                        break;
                    case "Remove":
                        if (CheckForTheTeam(team, input[1]))
                            team.RemovePlayer(input[2]);
                        else Console.WriteLine($"Player {input[2]} is not in {team.Name} team.");
                        break;
                    case "Rating":
                        if (CheckForTheTeam(team, input[1]))
                            Console.WriteLine(team);
                        else Console.WriteLine($"Team {input[1]} does not exists.");
                        break;
                }
            }
        }

        private static bool CheckForTheTeam(Team team, string check)
        {
            if (team.Name == check) return true;
            else return false;
        }
    }
}
