using System;
using System.Collections.Generic;
using System.Text;

namespace BruchRechner
{
    internal class Bruch
    {
        int zaehler;
        int nenner;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="zaehler"></param>
        /// <param name="nenner"></param>
        public Bruch(int zaehler, int nenner)
        {
            if(nenner == 0)
            {
                Console.WriteLine("Fehler! Nenner darf nicht null sein!");
            }
            this.zaehler = zaehler;
            this.nenner = nenner;
        }

        /// <summary>
        /// Constructor Overload
        /// </summary>
        /// <param name="zaehler"></param>
        public Bruch(int zaehler)
        {
            this.zaehler = zaehler;
            this.nenner = 1;
        }

        /// <summary>
        /// Bruch in Dezimal umrechnen
        /// </summary>
        /// <returns></returns>
        public double GetDezimal()
        {
            return ((double)this.zaehler / (double)nenner);
        }

        /// <summary>
        /// 2 Brüche Multiplizieren und einen Bruch zurückgeben
        /// </summary>
        /// <param name="faktor"></param>
        /// <returns></returns>
        public Bruch Mult(Bruch faktor)
        {
            int iErgZaehler = zaehler * faktor.zaehler;
            int iErgNenner = this.nenner * faktor.nenner;

            Bruch erg = new Bruch(iErgZaehler, iErgNenner);

            return erg;
        }

        /// <summary>
        /// Subtrahiert 2 Brüche voneinander
        /// </summary>
        /// <param name="bruch2"></param>
        /// <returns></returns>
        public Bruch Subtr(Bruch bruch2)
        {
            int iKgv = nenner;
            int iZ1 = zaehler;
            int iZ2 = bruch2.zaehler;
            if (nenner != bruch2.nenner)
            {
                iKgv = nenner * bruch2.nenner;
                iZ1 = zaehler * bruch2.nenner;
                iZ2 = bruch2.zaehler * nenner;
            }
            Bruch erg = new Bruch(iZ1 - iZ2, iKgv);
            return erg;
        }

        /// <summary>
        /// Addiert 2 Brüche miteinander
        /// </summary>
        /// <param name="bruch2"></param>
        /// <returns></returns>
        public Bruch Add(Bruch bruch2)
        {
            int iKgv = nenner;
            int iZ1 = zaehler;
            int iZ2 = bruch2.zaehler;
            if (nenner != bruch2.nenner)
            {
                iKgv = nenner * bruch2.nenner;
                iZ1 = zaehler * bruch2.nenner;
                iZ2 = bruch2.zaehler * nenner;
            }
            Bruch erg = new Bruch(iZ1 + iZ2, iKgv);
            return erg;
        }

        /// <summary>
        /// Dividiert 2 Brüche
        /// </summary>
        /// <param name="bruch2"></param>
        /// <returns></returns>
        public Bruch Div(Bruch bruch2)
        {
            int iErgZ = zaehler * bruch2.nenner;
            int iErgN = nenner * bruch2.zaehler;
            Bruch erg = new Bruch(iErgZ, iErgN);
            return erg;
        }

        /// <summary>
        /// Kuerzt den Bruch
        /// </summary>
        public void Kuerzen()
        {
            int b = nenner;
            int a = zaehler;
            while(a%b != 0)
            {
                int iRest = a % b;
                a = b;
                b = iRest;
            }
            int ggt = b;
            zaehler = zaehler / ggt;
            nenner = nenner / ggt;
        }

        /// <summary>
        /// Bruch in String umwandeln
        /// </summary>
        /// <returns></returns>
        public string GetAusgabeString()
        {
            return "" + zaehler + "/" + nenner;
        }

        //public static Bruch Mult(Bruch faktor1, Bruch faktor2)
        //{
        //    int iErgZaehler = faktor1.zaehler * faktor2.zaehler;
        //    int iErgNenner = faktor1.nenner * faktor2.nenner;

        //    Bruch erg = new Bruch(iErgZaehler, iErgNenner);

        //    return erg;
        //}



    }
}
