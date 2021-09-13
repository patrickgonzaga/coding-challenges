using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars
{
    /* Class Name: Coordinates.cs
     * Description: Arena coordinates for Robots position use.
     */

    public class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coordinates(int xloc, int yloc)
        {
            X = xloc;
            Y = yloc;
        }
    }
}
