namespace BruchRechnerr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sAusgabe1 = "Hallo, gib einen Bruch ein";
            string sAusgabe2 = "Gib eine Operation ein [+, -, *, /]";
            string sAusgabe3 = "Gib einen weiteren Bruch ein";
            ConsolePrompt(sAusgabe1);

            Console.SetCursorPosition(0, 2);
            string sInpt1 = Console.ReadLine();
            string[] Array1 = sInpt1.Split("/");
            int iBruch1z = int.Parse(Array1[0]);
            int iBruch1n = int.Parse(Array1[1]);
            ConsolePrompt(sAusgabe2);
            Console.SetCursorPosition(5, 2);
            string sOperation = Console.ReadLine();
            ConsolePrompt(sAusgabe3);
            Console.SetCursorPosition(8, 2);
            string sInpt2 = Console.ReadLine();
            string[] Array2 = sInpt2.Split("/");
            int iBruch2z = int.Parse(Array2[0]);
            int iBruch2n = int.Parse(Array2[1]);

            //int iBruch1z = int.Parse(Console.ReadLine());
            //Console.WriteLine("---");
            //int iBruch1n = int.Parse(Console.ReadLine());
            //ConsolePrompt(sAusgabe2);
            //string sOperation = Console.ReadLine();
            //ConsolePrompt(sAusgabe3);
            //int iBruch2z = int.Parse(Console.ReadLine());
            //Console.WriteLine("---");
            //int iBruch2n = int.Parse(Console.ReadLine());


            Bruch bruch1 = new(iBruch1z, iBruch1n);
            Bruch bruch2 = new(iBruch2z, iBruch2n);
            if (sOperation == "+")
            {
                Bruch ergBruch = bruch1.Add(bruch2);
                ergBruch.Kuerzen();
                Console.SetCursorPosition(13, 2);
                Console.WriteLine("=  " + ergBruch.GetAusgabeString());
            }
            else if (sOperation == "-")
            {
                Bruch ergBruch = bruch1.Subtr(bruch2);
                ergBruch.Kuerzen();
                Console.SetCursorPosition(13, 2);
                Console.WriteLine("=  " + ergBruch.GetAusgabeString());
            }
            else if (sOperation == "*")
            {
                Bruch ergBruch = bruch1.Mult(bruch2);
                ergBruch.Kuerzen();
                Console.SetCursorPosition(13, 2);
                Console.WriteLine("=  " + ergBruch.GetAusgabeString());
            }
            else if (sOperation == "/")
            {
                Bruch ergBruch = bruch1.Div(bruch2);
                ergBruch.Kuerzen();
                Console.SetCursorPosition(13, 2);
                Console.WriteLine("=  " + ergBruch.GetAusgabeString());
            }

        }
        public static void ConsolePrompt(string sAusgabe)
        {
            Console.SetCursorPosition(0, 0);
            Console.Write(new string(' ', Console.BufferWidth)); // Zeile leeren
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(sAusgabe);
        }
    }
}