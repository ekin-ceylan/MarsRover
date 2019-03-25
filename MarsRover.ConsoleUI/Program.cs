using System;
using System.Collections.Generic;
using MarsRover.Business.Concrete;
using MarsRover.Business.Helper;

namespace MarsRover.ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Rover> roverList = new List<Rover>();
            Console.WriteLine("Press E to End Commands");

            try
            {
                string plateauInit = Console.ReadLine();
                Plateau plateau = new Plateau(CommandHelper.GetCoordinate(plateauInit));

                while (true)
                {
                    string roverInit = Console.ReadLine();

                    if (roverInit == "E")
                        break;

                    Rover rover = CommandHelper.CreateRover(roverInit, plateau);

                    string roverCommands = Console.ReadLine();
                    CommandHelper.ExecuteRoverCommands(roverCommands, rover);

                    roverList.Add(rover);

                    if (roverCommands == "E")
                        break;
                }

                foreach (Rover rover in roverList)
                {
                    Console.WriteLine(rover);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Command");
            }

            Console.WriteLine("Press any key to quit");
            Console.ReadKey();
        }
    }
}
