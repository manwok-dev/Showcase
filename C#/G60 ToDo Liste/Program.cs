namespace G60_ToDo_Liste
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            StreamWriter sw = new StreamWriter("C:\\Users\\Arbeit\\OneDrive - Berufsförderungswerk Dortmund\\BfW\\7. AE C#\\1 HJ\\AE\\G60 ToDo Liste\\savefile.txt");
            sw.WriteLine("Hello World!!");
            sw.Close();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

        }
    }
}