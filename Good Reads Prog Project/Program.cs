namespace Good_Reads_Prog_Project
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
            functions.dbCreate.InitializeDatabase();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}