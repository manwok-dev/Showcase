using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Pathfinding
{
    internal class Program
    {
        // Creating Points
        public static Points pA = new Points("a");
        public static Points pB = new Points("b");
        public static Points pC = new Points("c");
        public static Points pD = new Points("d");
        public static Points pE = new Points("e");
        public static Points pF = new Points("f");
        //AI
        public static Points pG = new Points("g");
        public static Points pH = new Points("h");
        public static Points pI = new Points("i");
        public static Points pJ = new Points("j");
        public static Points pK = new Points("k");
        public static Points pL = new Points("l"); 
        public static Points pM = new Points("m");
        public static Points pN = new Points("n");
        public static Points pO = new Points("o");
        public static Points pP = new Points("p");
        public static Points[] pArray = [pA, pB, pC, pD, pE, pF, pG, pH, pI, pJ, pK, pL, pM, pN, pO, pP];

        static void Main(string[] args)
        {
            // Creating connections between points/neighbours
            pA.SetNeighbour(pB, 5);
            pA.SetNeighbour(pE, 4);
            pB.SetNeighbour(pA, 18);
            pB.SetNeighbour(pC, 30);
            pC.SetNeighbour(pB, 33);
            pC.SetNeighbour(pD, 7);
            pC.SetNeighbour(pF, 4);
            pD.SetNeighbour(pA, 17);
            pD.SetNeighbour(pE, 5);
            pD.SetNeighbour(pF, 12);
            pE.SetNeighbour(pA, 11);
            pE.SetNeighbour(pD, 5);
            pF.SetNeighbour(pD, 13);
            //AI
            pA.SetNeighbour(pG, 6);
            pA.SetNeighbour(pH, 15);
            pB.SetNeighbour(pG, 8);
            pB.SetNeighbour(pI, 12);
            pC.SetNeighbour(pH, 5);
            pC.SetNeighbour(pJ, 9);
            pD.SetNeighbour(pJ, 4);
            pD.SetNeighbour(pK, 7);
            pE.SetNeighbour(pK, 8);
            pE.SetNeighbour(pL, 14);
            pF.SetNeighbour(pL, 3);
            pF.SetNeighbour(pM, 11);
            pG.SetNeighbour(pH, 2);
            pG.SetNeighbour(pN, 20);
            pH.SetNeighbour(pI, 4);
            pH.SetNeighbour(pJ, 8);
            pI.SetNeighbour(pJ, 2);
            pI.SetNeighbour(pO, 15);
            pJ.SetNeighbour(pK, 3);
            pJ.SetNeighbour(pM, 10);
            pK.SetNeighbour(pL, 2);
            pK.SetNeighbour(pN, 6);
            pL.SetNeighbour(pM, 2);
            pL.SetNeighbour(pP, 12);
            pM.SetNeighbour(pN, 1);
            pM.SetNeighbour(pO, 5);
            pN.SetNeighbour(pO, 2);
            pN.SetNeighbour(pP, 8);
            pO.SetNeighbour(pP, 2);
            // Cycles
            pJ.SetNeighbour(pG, 7);
            pN.SetNeighbour(pH, 4);
            pP.SetNeighbour(pK, 5);

            while (true)
            {
                Console.Write("Gib Startknoten ein: ");
                string sStartKnoten = Console.ReadLine();
                Console.Write("Gib Endknoten ein: ");
                string sEndKnoten = Console.ReadLine();

                Points pStart = GetPointFromInput(sStartKnoten);
                Points pEnd = GetPointFromInput(sEndKnoten);
                Path p = new Path(pStart, pEnd);
                Path path = PathClaculator.GetWay(p);
                List<Points> pList = path.GetPathPoints();
                Console.WriteLine("The Path is:");
                for (int i = 0; i < pList.Count; i++)
                {
                    Console.WriteLine(pList[i].name);
                }
                Console.WriteLine("Cost = " + path.GetCost());
            }
            
        }

        /// <summary>
        /// Gets the associated Point from the inputted character/string
        /// </summary>
        /// <param name="sInp"></param>
        /// <returns></returns>
        public static Points GetPointFromInput(string sInp)
        {
            for (int i = 0; i < pArray.Length; i++)
            {
                if (pArray[i].name == sInp)
                {
                    return pArray[i];
                }
            }
            return pA;
        }
    }
}