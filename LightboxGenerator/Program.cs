using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightboxGenerator
{
    public static class Program
    {
        public static Window mainWindow;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            mainWindow = new Window();
            Application.Run(mainWindow);
        }

        public static void SetTruck(string name)
        {
            mainWindow.currenttruck.Text = "Selected truck: " + name;
        }
    }
}
