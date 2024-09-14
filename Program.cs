namespace EnLaunch
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
            ApplicationConfiguration.Initialize();

            string savedMincraftPath = Properties.Settings.Default.MinecraftPath;

            if (
                Properties.Settings.Default.SetupComplete && 
                Directory.Exists(savedMincraftPath)
                )
            {
                Application.Run(new ControlForm(savedMincraftPath));
            } else
            {
                Application.Run(new SetupForm());
            }
        }
    }
}