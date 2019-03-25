using System;
using MarsRover.Business.Abstract;
using MarsRover.Business.Concrete;
using MarsRover.Business.Concrete.Commands;
using MarsRover.Business.Concrete.Orientations;
using MarsRover.Business.Enum;

namespace MarsRover.Business.Helper
{
    public static class CommandHelper
    {
        public static void ExecuteRoverCommands(string roverCommands, IRover rover)
        {
            foreach (char roverCommand in TrimCommand(roverCommands))
            {
                IRoverCommand command = RoverCommandFactory(roverCommand.ToString());

                command?.Execute(rover);
            }
        }

        public static Rover CreateRover(string command, Plateau plateau)
        {
            string[] commands = command.Split(' ');
            Coordinate coordinate = GetCoordinate(commands);
            OrientationState orientation = OrientationFactory(commands[2]);
            return new Rover(coordinate, orientation, plateau);
        }

        public static Coordinate GetCoordinate(string command)
        {
            string[] commands = command.Split(' ');
            return GetCoordinate(commands);
        }

        private static Coordinate GetCoordinate(string[] commands)
        {
            Int32.TryParse(commands[0], out var x);
            Int32.TryParse(commands[1], out var y);

            return new Coordinate(x, y);
        }

        public static IRoverCommand RoverCommandFactory(string command)
        {
            if (System.Enum.TryParse(command, out Command cmd))
            {
                switch (cmd)
                {
                    case Command.L:
                        return new TurnLeft();
                    case Command.R:
                        return new TurnRight();
                    case Command.M:
                        return new MoveForward();
                }
            }

            return null;
        }

        public static OrientationState OrientationFactory(string command)
        {
            if (System.Enum.TryParse(command, out Orientation cmd))
            {
                switch (cmd)
                {
                    case Orientation.N:
                        return new North();
                    case Orientation.E:
                        return new East();
                    case Orientation.S:
                        return new South();
                    case Orientation.W:
                        return new West();
                }
            }

            return new North();
        }


        private static string TrimCommand(string command)
        {
            return command.Replace(" ", string.Empty);
        }
    }
}
