//schreiben sie eine Methode, die eine dezimalzahl eingegeben bekommt und diese in einen string mithexadizimal
//zahlen umwandelt
internal class Program
{
    private static void Main(string[] args)
    {
        while(true)
        {
            Console.WriteLine("Gib eine Zahl ein, die in Hexadezimal umgerechnet werden soll");
            string sInput = Console.ReadLine();
            string sHexZahl = ToHex(sInput);
            Console.WriteLine(sHexZahl);
        }

    }

    /// <summary>
    /// Wandelt Dezimal-Zahlen in Hex-Zahlen um
    /// </summary>
    /// <param name="sUserInput"></param>
    /// <returns></returns>
    public static string ToHex(string sUserInput) 
    {
        int iUserInput = int.Parse(sUserInput);
        int iZahl = 0;  // Iterrationen-Zähler
        int iPotenzFactor = 16;
        int iPotenz = 1;    
        string sInputInHex = "";    // Input in Hex umgewandelt, als string gespeichert

        // wie oft iUserInput in iPotenz passt, wenn mehr als 15 = noch ein loop
        while ( (iUserInput / iPotenz) > 15)    
        {
            iZahl += 1; // +1 im Itterations-Zähler/Runden-Zähler
            iPotenz = (int)Math.Pow(iPotenzFactor, iZahl);  // iPotenz = iPotenzFactor ** iZahl
        }

        // setzt i = dem Itterations-Zähler | min i = 0 für durchlauf | i -= 1 nach durchlauf
        for (int i = iZahl; i >= 0; i--)
        {
            iPotenz = (int)Math.Pow(iPotenzFactor, i); // iPotenz = 16 ** i
            int iHexZahl = iUserInput / iPotenz;    // iHexZahl = eingegebene Zahl / potenz, umwandlung in int schneidet rest ab
            string sHexZahl = iHexZahl.ToString();  // speichert iHexZahl als string

            if (iHexZahl >= 10) // wenn iHexZahl grösser als 10
            {
                if (iHexZahl == 10) // bei 10
                {
                    sHexZahl = "A"; // Setze sHexZahl als A
                }

                else if (iHexZahl == 11) // usw
                {
                    sHexZahl = "B";
                }

                else if (iHexZahl == 12)
                {
                    sHexZahl = "C";
                }

                else if (iHexZahl == 13)
                {
                    sHexZahl = "D";
                }

                else if (iHexZahl == 14)
                {
                    sHexZahl = "E";
                }

                else if (iHexZahl == 15)
                {
                    sHexZahl = "F";
                }

            }

            iUserInput %= iPotenz; // gibt den Rest des user inputs aus, der übrig bleibt bei iUserInput/iPotenz
            sInputInHex = (sInputInHex + sHexZahl); // fügt sInputHex den sHexZahl wert hinzu
        }
        
        return sInputInHex; // return sInputHex
    }
}