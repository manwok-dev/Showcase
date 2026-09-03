using System.Runtime.ConstrainedExecution;

namespace Aufgaben_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] iArray = [1, 4, 7, 9, 100];
            int[] iArray2 = [1, 4, 7, 100, 3];
            double[] dArray = [1, 4, 7, 100, 7];
            char[] cArray = ['a', 'b', 'c', 'd', 'e','f'];
            Console.WriteLine( SumOfArray(iArray) );
            Console.WriteLine( AvgOfArray(dArray) );
            Console.WriteLine( Max(iArray) );
            Console.WriteLine( Amount(iArray, 1) );
            int[] iEvenNumberArray = EvenNumbers(iArray);
            for (int i = 0; i < iEvenNumberArray.Length; i++)
            {
                Console.Write(iEvenNumberArray[i] + ", ");
            }
            Console.Write("\n");
            int[] iMirrored = MirroredArray(iArray);
            for (int i = 0; i < iMirrored.Length; i++)
            {
                Console.Write(iMirrored[i] + ", ");
            }
            Console.Write("\n");
            int[] iDoubled = DoubleValues(iArray);
            for (int i = 0; i < iDoubled.Length; i++)
            {
                Console.Write(iDoubled[i] + ", ");
            }
            Console.Write("\n");
            MirroredOutput(cArray);
            Console.WriteLine( CheckAsc(iArray) );
            Console.WriteLine( CompareArrays(iArray, iArray2) );
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die ein Array von int-Werten erhält und die Summe aller Elemente zurückgibt
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static int SumOfArray(int[] iArray)
        {
            int iSum = 0;
            for(int i=0; i<iArray.Length; i++)
            {
                iSum += iArray[i];
            }
            return iSum;
        }
        /// <summary>
        ///Erstellen Sie eine Methode, die ein Array von double erhält und den Durchschnitt der Werte berechnet
        /// </summary>
        /// <param name="dArray"></param>
        /// <returns></returns>
        public static double AvgOfArray(double[] dArray)
        {
            double dAvg = 0;
            for (int i = 0; i < dArray.Length; i++)
            {
                dAvg += dArray[i];
            }
            return dAvg / dArray.Length;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die den größten Wert in einem int-Array zurückgibt.
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static int Max(int[] iArray) 
        {
            int iMax = iArray[0];
            for (int i=1; i < iArray.Length; i++)
            {
                if (iArray[i] > iMax)
                {
                    iMax = iArray[i];
                }
            }
            return iMax;
        }

        /// <summary>
        /// Erstellen Sie eine Methode, die ein Array und einen Suchwert erhält und zählt, wie oft dieser Wert im Array vorkommt.

        /// </summary>
        /// <param name="iArray"></param>
        /// <param name="iWert"></param>
        /// <returns></returns>
        public static int Amount(int[] iArray, int iWert)
        {
            int iAmount = 0;
            for(int i=0; i < iArray.Length; i++)
            {
                if (iArray[i] == iWert)
                {
                    iAmount++;
                }
            }
            return iAmount;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die alle geraden Zahlen aus einem Array von Ganzzahlen herausfiltert und in einem neuen Array zurückgibt.
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static int[] EvenNumbers(int[] iArray)
        {
            int y = 0;
            for (int i = 0; i < iArray.Length; i++)
            {
                if (iArray[i] % 2 == 0)
                {
                    y++;
                }
            }
            int[] iEvenNumbers = new int[y];
            int z = 0;
            for (int i = 0; i < iArray.Length; i++)
            {
                if (iArray[i] % 2 == 0)
                {
                    iEvenNumbers[z] = iArray[i];
                    z++;
                }
            }

            return iEvenNumbers;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die ein Array von int-Werten umdreht (erstes Element wird letztes usw.). 
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static int[] MirroredArray(int[] iArray)
        {
            int y = iArray.Length - 1;
            int[] iMirrored = new int[iArray.Length];
            for (int i = 0; i < iArray.Length; i++)
            {
                iMirrored[y] = iArray[i];
                y--;
            }
            return iMirrored;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die ein Array von int erhält und ein neues Array zurückgibt, in dem jeder Wert verdoppelt wurde.
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static int[] DoubleValues(int[] iArray)
        {
            int[] iDoubled = new int[iArray.Length];
            for (int i = 0; i < iArray.Length; i++)
            {
                iDoubled[i] = iArray[i] * 2;
            }
            return iDoubled;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die ein Array von Zeichen (char[]) in umgekehrter Reihenfolge auf der Konsole ausgibt, ohne das Array selbst zu verändern.
        /// </summary>
        /// <param name="cArray"></param>
        public static void MirroredOutput(char[] cArray)
        {
            for (int i = cArray.Length -1; i >= 0; i--)
            {
                Console.Write(cArray[i] + ", ");
            }
            Console.Write("\n");
        }

        /// <summary>
        /// Erstellen Sie eine Methode, die prüft, ob ein int-Array aufsteigend sortiert ist. 
        /// </summary>
        /// <param name="iArray"></param>
        /// <returns></returns>
        public static bool CheckAsc(int[] iArray)
        {
            for (int i = 1; i < iArray.Length; i++)
            {
                if (iArray[i] > iArray[i-1])
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Schreiben Sie eine Methode, die zwei Arrays erhält und prüft, ob sie inhaltlich gleich sind(gleiche Länge, gleiche Werte in gleicher Reihenfolge).
        /// </summary>
        /// <param name="iArray"></param>
        /// <param name="iArray2"></param>
        /// <returns></returns>
        public static bool CompareArrays(int[]iArray, int[] iArray2)
        {
            if (iArray.Length == iArray2.Length)
            {
                for (int i = 0; i < iArray.Length; i++)
                {
                    if( iArray[i] == iArray2[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
