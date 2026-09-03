using System;
using System.Collections.Generic;
using System.Text;

namespace ViktorMeth
{
    public class Viktor
    {
        int x;
        int y;
        int z;


        public Viktor(int px, int py, int pz)
        {
            x = px;
            y = py;
            z = pz;
        }

        public Viktor Add(Viktor a)
        {
            int ergX = a.x + x;
            int ergY = a.y + y;
            int ergZ = a.z + z;
            Viktor ergV = new Viktor(ergX, ergY, ergZ);
            return ergV;
        }
        public Viktor Subtr(Viktor a)
        {
            int ergX = x -a.x;
            int ergY = y - a.y;
            int ergZ = z - a.z;
            Viktor ergV = new Viktor(ergX, ergY, ergZ);
            return ergV;
        }

        public Viktor Cross(Viktor a)
        {
            int ergX = (y * a.z) - (z * a.y);
            int ergY = (z * a.x) - (x * a.z);
            int ergZ = (x * a.y) - (y * a.x);
            Viktor ergV = new Viktor(ergX, ergY, ergZ);
            return ergV;
        }

        public int Skalar(Viktor a)
        {
            return (x * a.x) + (y * a.y) + (z * a.z);
        }

        public double[] Leng(Viktor a)
        {
            double[] erg = new double[2];
            erg[0] = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
            erg[1] = Math.Sqrt(Math.Pow(a.x, 2) + Math.Pow(a.y, 2) + Math.Pow(a.z, 2));
            return erg;
        }

        public double Angel(Viktor a)
        {
            double[] leng = this.Leng(a);
            double i = leng[0];
            double j = leng[1];
            return Math.Acos((this.Skalar(a)) / (i * j)) * (180 / Math.PI);
        }

        public string OutputStr()
        {
            return "X = " + x + ", Y = " + y + ", Z = " + z;
        }
    }
}
