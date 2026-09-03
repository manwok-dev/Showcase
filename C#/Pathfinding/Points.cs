using System;
using System.Collections.Generic;
using System.Text;

namespace Pathfinding
{
    internal class Points
    {
        public string name = "";
        public List<Neighbour> neighbours = new List<Neighbour>();

        public Points(string sName)
        {
            name = sName;
        }

        public void SetNeighbour(Points destination, int iCost)
        {
            Neighbour n = new Neighbour(destination, iCost);
            neighbours.Add(n);
        }
    }
}
