internal class Program
{
    private static void Main(string[] args)
    {
        Begruessung();
        BegruessungMitNamen("Manuel");
        ZeichenLinie();
        AktuellesDatum();
        BerechneAlter(1998);
        MultipliziereZahl(6);
        Spruch();
        WiederholeText("Moin Meister", 5);
        Console.WriteLine( Addiere(5, 100) );
        Console.WriteLine(Subtrahiere(5, 100));
        Console.WriteLine(Quadrat(5));
        Console.WriteLine(IstGerade(5));
        Console.WriteLine(IstNegativ(-5));
        Console.WriteLine(BerechneFlaeche(5, 5) );
        Console.WriteLine(CelsiusZuFahrenheit(20));
        Console.WriteLine(Vokal('i') );
        Console.WriteLine(Maximum(20, 10));
        Console.WriteLine(Minimum(5, 10));
        Console.WriteLine(Wuerfeln());
    }

    /// <summary>
    /// Gibt "Hallo Welt!" auf der Konsole aus.
    /// </summary>
    public static void Begruessung()
    {
        Console.WriteLine("Hello World");
    }

    /// <summary>
    /// Gibt "Hallo, [Name]!" aus
    /// </summary>
    /// <param name="name"></param>
    public static void BegruessungMitNamen(string name)
    {
        Console.WriteLine("Hello  " + name);
    }

    /// <summary>
    /// Gibt eine Trennlinie wie ---------------- aus
    /// </summary>
    public static void ZeichenLinie()
    {
        Console.WriteLine("----------------");
    }

    /// <summary>
    /// Gibt das heutige Datum aus
    /// </summary>
    public static void AktuellesDatum()
    {
        Console.WriteLine(DateTime.Now);
    }

    /// <summary>
    /// Berechnet das Alter auf Basis des Geburtsjahres und gibt es aus
    /// </summary>
    public static void BerechneAlter(int iZahl)
    {
        System.DateTime datum = DateTime.Now;
        int jahr = datum.Year;
        Console.WriteLine( (jahr - iZahl) );
    }

    /// <summary>
    /// Gibt die 1er–10er-Reihe der Zahl aus
    /// </summary>
    /// <param name="iZahl"></param>
    public static void MultipliziereZahl(int iZahl)
    {
        int[] iMultiplikation = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        for(int i=0; i<iMultiplikation.Length; i++)
        {
            Console.Write((iZahl * iMultiplikation[i]) + ", " );
        }
        Console.Write("\n");
    }

    /// <summary>
    /// Gibt einen motivierenden Spruch aus
    /// </summary>
    public static void Spruch()
    {
        Console.WriteLine("Weiter so!");
    }

    /// <summary>
    /// Gibt den Text mehrfach aus.
    /// </summary>
    /// <param name="Text"></param>
    /// <param name="Anzahl"></param>
    public static void WiederholeText(string sText, int iAnzahl)
    {
        for(int i=0; i<iAnzahl; i++)
        {
            Console.WriteLine(sText);
        }
    }

    /// <summary>
    ///Gibt die Summe zurück.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Addiere(int a, int b)
    {
        return a + b;
    }

    /// <summary>
    /// Gibt die Differenz zurück.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Subtrahiere(int a, int b)
    {
        return a - b;
    }

    /// <summary>
    /// Gibt x * x zurück. 
    /// </summary>
    /// <param name="x"></param>
    /// <returns></returns>
    public static int Quadrat(int x)
    {
        return x * x;
    }

    /// <summary>
    /// Prüft, ob die Zahl gerade ist.
    /// </summary>
    /// <param name="Zahl"></param>
    /// <returns></returns>
    public static bool IstGerade(int Zahl)
    {
        if ( (Zahl % 2) == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        //return (Zahl % 2) == 0;
    }

    /// <summary>
    /// Gibt true zurück, wenn die Zahl kleiner als 0 ist.
    /// </summary>
    /// <param name="Zahl"></param>
    /// <returns></returns>
    public static bool IstNegativ(int Zahl)
    {
        if(Zahl < 0)
        {
            return true;
        }
        else
        {
            return false;
        }
        //return Zahl < 0;
    }

    /// <summary>
    ///Gibt die Fläche eines Rechtecks zurück.
    /// </summary>
    /// <param name="dBreite"></param>
    /// <param name="dHoehe"></param>
    /// <returns></returns>
    public static double BerechneFlaeche(double dBreite, double dHoehe)
    {
        return dBreite * dHoehe;
    }

    /// <summary>
    /// Rechnet Celsius in Fahrenheit um.
    /// </summary>
    /// <param name="celsius"></param>
    /// <returns></returns>
    public static double CelsiusZuFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) +32;
    }

    /// <summary>
    /// Gibt true zurück, wenn es ein Vokal ist. 
    /// </summary>
    /// <param name="buchstabe"></param>
    /// <returns></returns>
    public static bool Vokal(char buchstabe)
    {
        char[] cArray = ['a', 'e', 'i', 'o', 'u'];
        for(int i=0; i<cArray.Length; i++)
        {
            if (cArray[i] == buchstabe)
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    ///Gibt die größere Zahl zurück.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Maximum(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }

    /// <summary>
    ///Gibt die kleinere Zahl zurück.
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Minimum(int a, int b)
    {
        if (a < b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
    /// <summary>
    /// Random Zahl zwischen 1-6
    /// </summary>
    /// <returns></returns>
    public static int Wuerfeln()
    {
        Random random = new Random();
        return random.Next(1, 6);
    }
}