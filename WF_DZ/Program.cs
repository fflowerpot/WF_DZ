using WF_DZ._17._06._2023;
using WF_DZ._22._06._2023;
using WF_DZ._24._09._2023;
namespace WF_DZ
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
            //Application.Run(new Anketa());
            //Application.Run(new OrderManagerForm());
            Application.Run(new Perent());
        }
    }
}