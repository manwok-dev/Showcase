using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Linq;

namespace Pathfinding
{
    internal class Path
    {
        public List<Neighbour> wayPoints = new List<Neighbour>();
        public Points startPoint;
        public Points endPoint;

        public Path(Points start, Points end)
        {
            startPoint = start;
            endPoint = end;
        }

        public Path Clone()
        {
            List<Neighbour> copy = new List<Neighbour>();
            for (int i = 0; i<wayPoints.Count; i++)
            {
                copy.Add(wayPoints[i]);
            }
            Path p = new Path(startPoint, endPoint);
            p.wayPoints = copy;
            return p;
        }

        public int GetCost()
        {
            int cost = 0;
            for(int i = 0; i<wayPoints.Count; i++)
            {
                cost += wayPoints[i].cost;
            }
            return cost;
        }

        public Points GetLastPoint()
        {
            return wayPoints[(wayPoints.Count - 1)].destination;
        }

        public void AddNeighbour(Neighbour n)
        {
            wayPoints.Add(n);
        }

        public List<Points> GetPathPoints()
        {
            List<Points> pList = new List<Points> 
            {
                {startPoint}
            };
            if(wayPoints.Count > 0)
            {
                for(int i = 0; i<wayPoints.Count; i++)
                {
                    pList.Add(wayPoints[i].destination);
                }
            }
                return pList;
        }
    }
}
