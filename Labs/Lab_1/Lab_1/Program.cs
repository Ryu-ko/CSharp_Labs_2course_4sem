namespace Lab_1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  все потоки в этой программе выполн€ютс€ в рамках одного процесса
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Calculator());
        }
    }
}