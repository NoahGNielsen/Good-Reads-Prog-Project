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

            var config = new Config();

            try
            {
                if (config.devMode)
                {
                    functions.dbCreate.InitializeDatabase();
                    MessageBox.Show("Database initialized successfully.", "Database Initialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    functions.dbCreate.InitializeDatabase();
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error initializing database: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}