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
            Dictionary<string, Trainer> dict = new Dictionary<string, Trainer>();
            string cmd;
            while ((cmd = Console.ReadLine()) != "Tournament")
            {
                string[] cmdArgs = cmd.Split(' ').ToArray();
                Pokemon pokemon = new Pokemon(cmdArgs[1], cmdArgs[2], double.Parse(cmdArgs[3]));
                if (dict.ContainsKey(cmdArgs[0]))
                {
                    dict[cmdArgs[0]].Pokemons.Add(pokemon);
                }
                else
                {
                    dict.Add(cmdArgs[0], new Trainer(cmdArgs[0], new List<Pokemon>() { pokemon }));
                }
            }
            while ((cmd = Console.ReadLine()) != "End")
            {
                foreach (var trainer in dict)
                {
                    bool check = false;
                    for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                    {
                        if (trainer.Value.Pokemons[i].Element == cmd) check = true;
                    }
                    if (!check)
                    {
                        trainer.Value.DealDamage(trainer.Value.Pokemons, 10);
                    }
                    else trainer.Value.CountOfBadges++;
                }
            }
            foreach (var trainer in dict.OrderByDescending(x => x.Value.CountOfBadges))
            {
                Console.WriteLine(trainer.Value);
            }
        }
    }
}