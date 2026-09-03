using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(UmfangBerechnen(10) );
        Console.WriteLine(SchaltjahrCheck(2021));
        Console.WriteLine(ReverseString("Hallo, ich heisse Manuel!") );
        Console.WriteLine(Prozentwert(300, 1.5));
        Console.WriteLine(Potenz(10, 5) );
        Console.WriteLine(NettoPreis(100, 19) );

        int[] iArray = Sortieren();
        for(int i=0; i<iArray.Length; i++)
        {
            Console.WriteLine(iArray[i]);
        }
    }

    /// <summary>
    /// Erstellen Sie eine Methode in C#, die den Radius eines Kreises übergeben
    //bekommt und den Umfang berechnet.
    //(Formel: U = 2 * π* r)
    /// </summary>
    /// <param name="radius"></param>
    /// <returns></returns>
    public static float UmfangBerechnen(float radius)
    {
        return 2 * (float)Math.PI * radius;
    }


    /// <summary>
    /// Schreiben Sie eine Methode, die eine Jahreszahl als Parameter erhält und
    //überprüft, ob es sich um ein Schaltjahr handelt.
    /// </summary>
    /// <param name="jahr"></param>
    /// <returns></returns>
    public static bool SchaltjahrCheck(int jahr)
    {
        if (jahr % 4 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// Erstellen Sie eine Methode, die einen String entgegennimmt und ihn umgekehrt
    //(rückwärts) zurückgibt
    /// </summary>
    /// <param name="sText"></param>
    /// <returns></returns>
    public static string ReverseString(string sText)
    {
        char[] cArray = sText.ToCharArray();
        string sRueckgabe = "";
        for (int i = cArray.Length -1; i > -1; i--)
        {
            sRueckgabe += cArray[i];
        }
        return sRueckgabe;
    }

    /// <summary>
    /// Schreiben Sie eine Methode, die einen Grundwert und einen Prozentsatz erhält
    //und den Prozentwert berechnet.
    /// </summary>
    /// <param name="Zahl"></param>
    /// <param name="Prozent"></param>
    /// <returns></returns>
    public static double Prozentwert(double Zahl, double Prozent)
    {
        return Zahl * (Prozent / 100);
    }

    /// <summary>
    /// Erstellen Sie eine Methode, die zwei Zahlen (Basis und Exponent) als Parameter
    //entgegennimmt und die Potenz berechnet.
    /// </summary>
    /// <param name="Zahl"></param>
    /// <param name="Potenz"></param>
    /// <returns></returns>
    public static double Potenz(double Zahl, double Potenz)
    {
        return Math.Pow(Zahl, Potenz);
    }


    public static double NettoPreis(double BruttoPreis, double Steuer)
    {
        return BruttoPreis + BruttoPreis * (Steuer / 100);
    }


    public static int[] Sortieren()
    {
        int[] iArray = { 4, 15, 16, 32, 8, 1, 99 };
        for(int i=0; i<iArray.Length - 1; i++)
        {
            if (iArray[i] <= iArray[i+1])
            {
                continue;
            }
            else
            {
                while (iArray[i] > iArray[i + 1])
                {
                    int y = iArray[i];
                    iArray[i] = iArray[i + 1];
                    iArray[i + 1] = y;
                }
            }
        }
        return iArray;
    }
}