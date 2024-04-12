namespace GameGUI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect arguments. Expected: map file path");
                return;
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            try
            {
                Application.Run(new GameForm(args[0]));
            }
            catch (Exception e) when (
                e is FileNotFoundException || e is DirectoryNotFoundException)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
