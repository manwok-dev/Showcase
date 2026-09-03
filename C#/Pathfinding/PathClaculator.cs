using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Pathfinding
{
    internal class PathClaculator
    {
        List<Points> pointList;

        public static Path GetWay(Path path)
        {
            //List<Points> l = path.GetPathPoints();
            //for(int i = 0; i<l.Count; i++)
            //{
            //    Console.WriteLine(l[i].name);
            //}
            //Console.WriteLine("");
            Points curP;    //current Point
            if (path.wayPoints.Count == 0)
            {
                curP = path.startPoint;
            }
            else
            {
                curP = path.wayPoints[(path.wayPoints.Count - 1)].destination;
            }

            List<Path> possiblePathList = new List<Path>();
            for (int i = 0; i < curP.neighbours.Count; i++)
            {
                Neighbour curN = curP.neighbours[i];
                if (curN.destination == path.endPoint)
                {
                    path.AddNeighbour(curN);
                    possiblePathList.Add(path);
                }
                else if (path.GetPathPoints().Contains(curN.destination) | curN.destination == path.startPoint)
                {
                    continue;
                }
                else
                {
                    Path pNew = path.Clone();
                    pNew.AddNeighbour(curN);
                    pNew = GetWay(pNew);
                    if (pNew.wayPoints.Count > path.wayPoints.Count)
                    {
                        possiblePathList.Add(pNew);
                    }
                }
            }
            if (possiblePathList.Count != 0)
            {
                Path minCostPath = possiblePathList[0];
                for (int i = 1; i < possiblePathList.Count; i++)
                {
                    if (possiblePathList[i].GetCost() < minCostPath.GetCost())
                    {
                        minCostPath = possiblePathList[i];
                    }
                }
                return minCostPath;
            }
            else
            {
                path.wayPoints.RemoveAt(path.wayPoints.Count - 1);
                return path;
            }
        }
   
    }
}
