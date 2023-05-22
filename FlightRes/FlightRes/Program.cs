using System.Security.Cryptography.X509Certificates;

namespace FlightRes
{
    internal static class Program
    {
        public static String connectionString = "Data Source =.; Initial Catalog = FlightSystem; Integrated Security = True";
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Start());
        }
    }
}