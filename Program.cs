using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            // Start with the Login form instead of MainDashboard
            Application.Run(new Login()); 
        }
    }
}