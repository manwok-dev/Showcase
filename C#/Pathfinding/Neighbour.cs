using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
    internal class Neighbour
    {
        public Points destination;
        public int cost;

        public Neighbour(Points point, int iCost)
        {
            destination = point;
            cost = iCost;
        }
    }
}
