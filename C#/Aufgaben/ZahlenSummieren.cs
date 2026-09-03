using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class ZahlenSummieren
{
        
    private static void Main(string[] args)
    {
        //Erstelle ein Array mit 5 Ganzzahlen.Berechne die Summe aller Elemente.
        int iSumme = 0;
        int[] iArray = [15, 15, 35, 87, 235];
        for(int i = 0; i<5; i++)
        {
            iSumme = iSumme + iArray[i];
        }
        Console.WriteLine("1 " + iSumme);

        //Finde das größte Element in einem Array
        int iGroessteZahl = iArray[0];
        for (int i = 0; i < 5; i++)
        {
            if (iGroessteZahl < iArray[i])
            {
                iGroessteZahl = iArray[i];
            }
        }
        Console.WriteLine("2 " + iGroessteZahl);

        //Gib die Elemente eines Arrays rückwärts aus
        for (int i = (iArray.Length - 1); i >= 0; i--)
        {
            Console.WriteLine("3 " + iArray[i]);
        }

        //Berechne den Durchschnitt eines Arrays mit Gleitkommazahlen
        float fDurchschnitt = (float)iSumme / (float)iArray.Length;
        Console.WriteLine("4 " + fDurchschnitt);

        //Zähle, wie oft eine bestimmte Zahl im Array vorkommt
        int iBestimmteZahl = 15;
        int iBestimmteZahlCounter = 0;
        for(int i=0; i < iArray.Length; i++)
        {
            if (iArray[i] == iBestimmteZahl)
            {
                iBestimmteZahlCounter++;
            }
            else
            {
                continue;
            }

        }
        Console.WriteLine("5 " + iBestimmteZahlCounter);

        //Vergleiche, ob zwei Arrays denselben Inhalt haben
        bool bGleicherInhalt = false;
        int[] iArray2 = [15, 15, 35, 87, 235];

        for(int i=0; i < iArray.Length; i++)
        {
            if (iArray[i] == iArray2[i])
            {
                if(i == 4)
                {
                    bGleicherInhalt = true;
                }
                continue;
            }
            else
            {
                break;
            }
        }
        Console.WriteLine("6 " + bGleicherInhalt);

        //Erstelle und gib eine kleine Multiplikationstabelle(3x3) aus
        int[] iMultTab1 = [0, 1, 2, 3];
        int[] iMultTab2 = [0, 1, 2, 3];

        for (int i = 0; i < iMultTab1.Length; i++)
        {
            for(int y = 0; y < iMultTab2.Length; y++)
            {
                Console.Write(iMultTab2[y] * iMultTab1[i]);
            }
            Console.WriteLine(" ");
        }


    }
}