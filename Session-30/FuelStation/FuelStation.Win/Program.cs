using Microsoft.VisualBasic.Logging;

namespace FuelStation.Win
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
          // Application.Run(new CustomerF());
            //Application.Run(new ItemF());
            //Application.Run(new TransactionF());
            // Application.Run(new TransactionLineF());
            Application.Run(new LoginF());



        }
    }
}