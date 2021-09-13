using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    /* Class Name: LetsPlay.cs
     * Description: Robot Wars start gameplay, movements and validation
     */
    public class LetsPlay
    {
        string[] gameParam = new string[5];
        Coordinates ArenaSize;

        public LetsPlay(string[] input)
        {
            gameParam = input;
        }

        public bool RobotWarsBeginPlay()
        {
            ArenaSize = GetArena(gameParam[0]);
            if (ArenaSize == null)
                return false;
           Robots robotOne = CheckRobotInfo("One", gameParam[1]);
            if (robotOne == null)
                return false;
            Robots robotTwo = CheckRobotInfo("Two", gameParam[3]);
            if (robotTwo == null)
                return false;

            MoveRobot(robotOne, ArenaSize, gameParam[2]);
            MoveRobot(robotTwo, ArenaSize, gameParam[4]);
            return true;
        }

        public Coordinates GetArena(string area)
        {
            string[] areaCoordinates = area.Split(' ');
            if (areaCoordinates.Length != 2)
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int myVal = 0;
            if (!int.TryParse(areaCoordinates[0], out myVal))
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int x = myVal;
            if (!int.TryParse(areaCoordinates[1], out myVal))
            {
                Console.WriteLine("Invalid Arena Size!");
                return null;
            }
            int y = myVal;
            return new Coordinates(x, y);
        }

        public Robots CheckRobotInfo(string robotno, string input)
        {
            string[] cardinalLoc = { "N", "S", "E", "W" };
            string[] robotRaw = input.Split(' ');

            if (robotRaw.Length != 3)
            {
                Console.WriteLine("Invalid Robot " + robotno + " Information");
                return null;
            }
            int myVal = 0;
            if (!int.TryParse(robotRaw[0], out myVal))
            {
                Console.WriteLine("Invalid Robot " + robotno + " Information");
                return null;
            }
            int x = myVal;
            if (!int.TryParse(robotRaw[1], out myVal))
            {
                Console.WriteLine("Invalid Robot " + robotno + " Information");
                return null;
            }
            int y = myVal;

            var found = cardinalLoc.Where(j => j.Contains(robotRaw[2].ToUpper())).FirstOrDefault();
            if (found == null)
            {
                Console.WriteLine("Invalid Robot " + robotno + " Information");
                return null;
            }
            return new Robots(x, y, robotRaw[2].ToUpper());
        }

        public void MoveRobot(Robots robots, Coordinates coordinates, string cmd)
        {
            if (cmd.Length > 0)            
                for (int i = 0; i < cmd.Length; i++)
                    robots.Instruction(cmd.Substring(i, 1), coordinates);

            Console.WriteLine(robots.X.ToString() + " " + robots.Y.ToString() + " " + robots.Direction);
        }
    }
}
