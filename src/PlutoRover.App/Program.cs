using System;
using PlutoRover.Core;

namespace PlutoRover.App
{
    public class Program
    {
        public static void Main(params string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to the Pluto Rover API!");
                Console.WriteLine("Commands:");
                Console.WriteLine("F: Move Forwards");
                Console.WriteLine("B: Move Backwards");
                Console.WriteLine("L: Turn Left");
                Console.WriteLine("R: Turn Right");

                var grid = Grid.InitialiseFrom(100, 100)
                    .AddObstacle(new Position(10, 10))
                    .AddObstacle(new Position(11, 10))
                    .AddObstacle(new Position(12, 10));

                var rover = new Rover(Position.Zero, Heading.N, grid);
                var roverApi = new RoverApi(rover);

                while (true)
                {
                    Console.Write("Please enter your commands: ");
                    roverApi.Process(Console.ReadLine());
                    Console.WriteLine($"Rover: {rover.GetLocation()}");
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}