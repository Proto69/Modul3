using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        public static bool isRunning = true;
        static void Main(string[] args)
        {
            RaceTower RaceTower = new RaceTower();
            RaceTower.SetTrackInfo(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            List<string> input;
            while (isRunning)
            {
                input = Console.ReadLine().Split(' ').ToList();
                try
                {
                    switch (input[0])
                    {
                        case "RegisterDriver":
                            RaceTower.RegisterDriver(input);
                            break;
                        case "Leaderboard":
                            RaceTower.GetLeaderboard();
                            break;
                        case "CompleteLaps":
                            if (RaceTower.MaxLaps < RaceTower.Lap + int.Parse(input[1]))
                                Console.WriteLine($"There is no time! On lap {RaceTower.Lap}.");
                            else 
                            for (int i = 0; i < int.Parse(input[1]); i++)
                            {
                                try
                                {
                                    RaceTower.CompleteLaps(input);
                                }
                                catch (ArgumentException k) { Console.WriteLine(k.Message); }
                            }
                            break;
                        case "Box":
                            RaceTower.DriverBoxes(input);
                            break;
                        case "ChangeWeather":
                            RaceTower.ChangeWeather(input);
                            break;
                    }
                }
                catch (ArgumentException k) { Console.WriteLine(k.Message); }
            }
        }
    }
}
