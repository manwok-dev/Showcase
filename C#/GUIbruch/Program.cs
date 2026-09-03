using BruchRechnerr;
namespace GUIbruch
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }

        public static string DoBruchMath(string sBruch1, string sBruch2, string sOperation)
        {
            if((sBruch1 != null) && (sBruch2 != null))
            {

                string[] Array1 = sBruch1.Split("/");
                string[] Array2 = sBruch2.Split("/");
                if (int.TryParse(Array1[0], out int zaehler1) && int.TryParse(Array1[1], out int nenner1)
                && int.TryParse(Array2[0], out int zaehler2) && int.TryParse(Array2[1], out int nenner2))
                {
                    int iBruch1z = zaehler1;
                    int iBruch1n = nenner1;
                    int iBruch2z = zaehler2;
                    int iBruch2n = nenner2;
                    Bruch bruch1 = new Bruch(iBruch1z, iBruch1n);
                    Bruch bruch2 = new Bruch(iBruch2z, iBruch2n);
                    string sErg = "";
                    if (sOperation == "+")
                    {
                        Bruch ergBruch = bruch1.Add(bruch2);
                        ergBruch.Kuerzen();
                        sErg = ergBruch.GetAusgabeString();
                    }
                    else if (sOperation == "-")
                    {
                        Bruch ergBruch = bruch1.Subtr(bruch2);
                        ergBruch.Kuerzen();
                        sErg = ergBruch.GetAusgabeString();
                    }
                    else if (sOperation == "/")
                    {
                        Bruch ergBruch = bruch1.Div(bruch2);
                        ergBruch.Kuerzen();
                        sErg = ergBruch.GetAusgabeString();
                    }
                    else if (sOperation == "*")
                    {
                        Bruch ergBruch = bruch1.Mult(bruch2);
                        ergBruch.Kuerzen();
                        sErg = ergBruch.GetAusgabeString();
                    }
                    return sErg;
                }
                else
                {
                    return "Please insert valid numbers";
                }

            }
            else
            {
                return "Please insert valid numbers";
            }
        }
    }
}