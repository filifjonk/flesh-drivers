using MySql.Data.MySqlClient;
using System.Data;

namespace PresentationLayer
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
            Application.Run(new Form1());
            //Application.Run(new Post());
            // Создание таймера
            //var timer = new System.Threading.Timer(
            //    e => CheckDevices(),
            //    null,
            //    TimeSpan.Zero,
            //    TimeSpan.FromMinutes(1)); //заменить на 10


            //while (true) { }

        }
    }
}
