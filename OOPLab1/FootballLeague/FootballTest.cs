﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague
{
    public class FootballTest
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            while (line != "End")
            {
                try
                {
                    LeagueManager.HandleInput(line);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                line = Console.ReadLine();
            }
        }
    }
}
